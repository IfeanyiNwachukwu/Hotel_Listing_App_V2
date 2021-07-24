﻿using AutoMapper;
using HotelListingAppVersion2.IRespository;
using HotelListingAppVersion2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingAppVersion2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CountryController> _logger;
        private readonly IMapper _mapper;

        public CountryController(IUnitOfWork unitOfWork, ILogger<CountryController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            try
            {
                var countries = await _unitOfWork.Countries.GetAll();
                var results = _mapper.Map<List<CountryDTO>>(countries);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went wrong {nameof(GetCountries)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCountry(int id)
        {
            try
            {
                var country = await _unitOfWork.Countries.Get(q => q.Id == id, new List<string>() {"Hotels"});
                var results = _mapper.Map<CountryDTO>(country);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went wrong {nameof(GetCountries)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later");
            }
        }
    }
}
