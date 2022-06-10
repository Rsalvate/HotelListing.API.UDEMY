using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Data.Entity;
using HotelListing.API.Models.Country;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class ContriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICountriesRepository _countriesRepository;

        public ContriesController(IMapper mapper, ICountriesRepository countriesRepository)
        {
            _mapper = mapper;
            _countriesRepository = countriesRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<GetCountryDto>>> Get()
        {
            var countries = await _countriesRepository.GetAllAsync();

            return Ok(_mapper.Map<List<GetCountryDto>>(countries));
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<CountryDto>> GetCountry(int id)
        {
            var country = await _countriesRepository.GetDetails(id);

            if (country == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CountryDto>(country));
        }

        [HttpPost]
        [Authorize(Roles ="Administrator")]
        public async Task<ActionResult<Country>> PostCountry(CreateCountryDto countryDto)
        {
            var country = _mapper.Map<Country>(countryDto);
            await _countriesRepository.AddAsync(country);

            return CreatedAtAction(nameof(GetCountry), new { id = country.Id }, country);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PutCountry(int id, UpdateCountryDtoBase updateCountryDto)
        {
            if (id != updateCountryDto.Id)
            {
                return BadRequest();
            }

            var country = await _countriesRepository.GetAsync(id);

            if (country == null)
            {
                return NotFound();
            }

            _mapper.Map(updateCountryDto, country);

            try
            {
                await _countriesRepository.UpdateAsync(country);
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!await CountryExists(id))
                {
                    return BadRequest(e.Message);
                }
                else
                {
                    return Problem(e.Message);
                }
            }

            return NoContent();
        }

        [HttpDelete]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var country = await _countriesRepository.GetAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            await _countriesRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> CountryExists(int id)
        {
            return await _countriesRepository.Exists(id);
        }
    }
}
