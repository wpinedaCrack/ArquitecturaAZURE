﻿using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;
using Tarker.Booking.Application.External.SendGridEmail;
using Tarker.Booking.Domain.Models.SendGridEmail;

namespace Tarker.Booking.External.SendGridEmail
{
    public class SendGridEmailService: ISendGridEmailService
    {
        private readonly IConfiguration _configuration;
        public SendGridEmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> Execute(SendGridEmailRequestModel model)
        {
            string apiKey = _configuration["SendGridEmailKey"];
            string apiUrl = "https://api.sendgrid.com/v3/mail/send";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            client.DefaultRequestHeaders.Add("Accept", $"application/json");

            string emailContent = JsonConvert.SerializeObject(model);

            var response = await client.PostAsync(apiUrl, new StringContent(emailContent, Encoding.UTF8, "application/json"));
            var dede = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}
