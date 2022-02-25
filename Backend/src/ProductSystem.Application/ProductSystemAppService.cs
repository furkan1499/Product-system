using System;
using System.Collections.Generic;
using System.Text;
using ProductSystem.Localization;
using Volo.Abp.Application.Services;

namespace ProductSystem;

/* Inherit your application services from this class.
 */
public abstract class ProductSystemAppService : ApplicationService
{
    protected ProductSystemAppService()
    {
        LocalizationResource = typeof(ProductSystemResource);
    }
}
