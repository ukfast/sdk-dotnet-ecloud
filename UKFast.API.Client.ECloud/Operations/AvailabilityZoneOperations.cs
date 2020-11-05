﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UKFast.API.Client.ECloud.Models.V2;
using UKFast.API.Client.Exception;
using UKFast.API.Client.Models;
using UKFast.API.Client.Request;

namespace UKFast.API.Client.ECloud.Operations
{
    public class AvailabilityZoneOperations<T> : ECloudOperations, IAvailabilityZoneOperations<T> where T : AvailabilityZone
    {
        public AvailabilityZoneOperations(IUKFastECloudClient client) : base(client)
        {
        }

        public async Task<IList<T>> GetAvailabilityZonesAsync(ClientRequestParameters parameters = null)
        {
            return await Client.GetAllAsync(GetAvailabilityZonesPaginatedAsync, parameters);
        }

        public async Task<Paginated<T>> GetAvailabilityZonesPaginatedAsync(ClientRequestParameters parameters = null)
        {
            return await Client.GetPaginatedAsync<T>("/ecloud/v2/availability-zones", parameters);
        }

        public async Task<T> GetAvailabilityZoneAsync(string azID)
        {
            if (string.IsNullOrWhiteSpace(azID))
            {
                throw new UKFastClientValidationException("Invalid availability zone id");
            }

            return await Client.GetAsync<T>($"/ecloud/v2/availability-zones/{azID}");
        }
    }
}