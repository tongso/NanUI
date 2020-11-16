﻿using NetDimension.NanUI.ResourceHandler;

namespace NetDimension.NanUI.DataServiceResource
{
    public sealed class RoutePutAttribute 
        : RouteMethodAttribute
    {
        public RoutePutAttribute(string routePath)
    : base(Method.PUT, routePath)
        {

        }
    }
}
