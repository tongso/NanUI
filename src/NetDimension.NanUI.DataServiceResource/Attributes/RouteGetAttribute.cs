﻿using NetDimension.NanUI.ResourceHandler;

namespace NetDimension.NanUI.DataServiceResource
{
    public sealed class RouteGetAttribute 
        : RouteMethodAttribute
    {
        public RouteGetAttribute(string routePath) 
            : base(Method.GET, routePath)
        {

        }
    }
}
