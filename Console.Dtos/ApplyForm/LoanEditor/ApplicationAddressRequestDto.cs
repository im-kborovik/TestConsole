﻿namespace Skynet.Dtos.ApplyForm.LoanEditor
{
    public class ApplicationAddressRequestDto
    {
        public string Country { get; set; }
        
        public string State { get; set; }
        
        public string Zip { get; set; }
        
        public string City { get; set; }
        
        public string Street { get; set; }
        
        public string Unit { get; set; }
    }
}