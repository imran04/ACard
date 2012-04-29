using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using System.Web.Routing;
using Offers.Core;
using Moq;

namespace Offers.Web.Infra
{
    public class NinjectControllerFactory : DefaultControllerFactory {
    private IKernel ninjectKernel;
    public NinjectControllerFactory() {
    ninjectKernel = new StandardKernel();
    AddBindings();
    }
protected override IController GetControllerInstance(RequestContext requestContext,
Type controllerType) {
return controllerType == null
? null
: (IController)ninjectKernel.Get(controllerType);
}
private void AddBindings() {
// put additional bindings here
    Mock<IRepository> mock = new Mock<IRepository>();
    mock.Setup(i=>i.CatLogs).Returns(new List<Catlog> { 
        new Catlog{ CatLogId=2, Desc="Computers", Name="Computers" ,Deals=new List<Deal>{
         new Deal{ DealId=Guid.NewGuid(), DealName="Computes", FullDesc="computer", ShortDesc="computer"},
          new Deal{ DealId=Guid.NewGuid(), DealName="Computes", FullDesc="computer", ShortDesc="computer"},
           new Deal{ DealId=Guid.NewGuid(), DealName="Computes", FullDesc="computer", ShortDesc="computer"}
        
        }},
        new Catlog{ CatLogId=1, Desc="Electronics", Name="Electronics",
        Deals=new List<Deal>{
         new Deal{ DealId=Guid.NewGuid(), DealName="Electronics", FullDesc="computer", ShortDesc="computer"},
          new Deal{ DealId=Guid.NewGuid(), DealName="Electronics", FullDesc="computer", ShortDesc="computer"},
           new Deal{ DealId=Guid.NewGuid(), DealName="Electronics", FullDesc="computer", ShortDesc="computer"}
        
        }
        },
        new Catlog{ CatLogId=3, Desc="Hard Disk", Name="HDD",Deals=new List<Deal>{
         new Deal{ DealId=Guid.NewGuid(), DealName="HDD", FullDesc="computer", ShortDesc="computer"},
          new Deal{ DealId=Guid.NewGuid(), DealName="HDD", FullDesc="computer", ShortDesc="computer"},
           new Deal{ DealId=Guid.NewGuid(), DealName="HDD", FullDesc="computer", ShortDesc="computer"}
        
        }}
        
 
    }.AsQueryable());
   
    this.ninjectKernel.Bind<IRepository>().ToConstant(mock.Object);
}
}
}