﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Simple_Eshop.TagHelpers
{
    public class EmailTagHelper: TagHelper
    {
        public string? Address { get; set; }
        public string? Content { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
        }
    }
}
