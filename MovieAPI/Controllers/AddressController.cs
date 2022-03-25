using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Entities;
using MovieAPI.Models.Adress;
using MovieAPI.Repositories.Adress;
using System;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private IAddressRepository _addressRepository;
        private IMapper _mapper;

        public AddressController(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddAddress([FromBody] AddressRequestModel addressModel)
        {
            Address address = _mapper.Map<Address>(addressModel);

            _addressRepository.Create(address);
            _addressRepository.Save();
            return CreatedAtAction(nameof(GetAddressById), new { Id = address.Id }, address);
        }

        [HttpGet]
        public IActionResult GetAllAddress()
        {
            return Ok(_addressRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetAddressById(Guid id)
        {
            var address = _addressRepository.GetById(id);
            if (address != null)
            {
                AddressResponseModel addressRequestModel = _mapper.Map<AddressResponseModel>(address);

                return Ok(addressRequestModel);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAddress(Guid id, [FromBody] UpdateAddressRequestModel addressModel)
        {
            var address = _addressRepository.GetById(id);

            if (address == null)
            {
                return NotFound();
            }

            _mapper.Map(addressModel, address);
            _addressRepository.Save();

            return NoContent();
        }
    }
}
