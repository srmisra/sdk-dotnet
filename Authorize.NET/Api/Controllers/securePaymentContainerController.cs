﻿namespace AuthorizeNet.Api.Controllers
{
    using System;
    using AuthorizeNet.Api.Contracts.V1;
    using AuthorizeNet.Api.Controllers.Bases;

#pragma warning disable 1591
    public class securePaymentContainerController : ApiOperationBase<securePaymentContainerRequest, securePaymentContainerResponse> {

	    public securePaymentContainerController(securePaymentContainerRequest apiRequest) : base(apiRequest) {
	    }

	    override protected void ValidateRequest() {
            var request = GetApiRequest();
		
		    //validate required fields		
		    if ( request.data == null) throw new ArgumentException( "Web checkout data cannot be null");
		    //if ( null == request.Paging) throw new ArgumentException("Paging cannot be null");
		
		    //validate not-required fields		
	    }

        //protected override void BeforeExecute()
        //{
        //    var request = GetApiRequest();
        //    RequestFactoryWithSpecified.securePaymentContainerType(request);
        //}
    }
#pragma warning restore 1591
}