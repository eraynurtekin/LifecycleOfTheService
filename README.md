## Dependency Injection Lifetime : Transient, Singleton & Scoped

ASP.NET Core'da Dependency Injection kullanılarak oluşturulan hizmetlerin kullanım ömrünü anlamak, bunları kullanmaya başlamadan önce çok önemlidir. Scoped Vs Transient Vs Singleton ömrü arasındaki farkı anlamadan hizmet oluşturmak, uygulamanın kararsız davranmasına neden olabilir. Bir hizmet DI aracılığıyla başka bir hizmet talep ettiğinde, yeni örneği mi yoksa mevcut bir örneği mi aldığını bilmek de çok önemlidir. Bu nedenle hizmet kaydı yapılırken kullanım süresinin doğru bir şekilde belirtilmesi son derece önemlidir.

### Transient: 
Transient servis her yeni istek talep edildiğinde yeni bir instance (örnek) oluşturur.
Her zaman yeni bir örneğini aldığımız için transient servisler en güvenli yoldur. Ancak, Dependency Injection her seferinde oluşturulduğundan, daha fazla bellek ve kaynak kullanımı olacaktır ve bu da performans üzerinde olumsuz etkisi olacaktır.

### Scoped:
Scoped servis, her istek(request) için yalnızca bir kez oluşuturulur yani istek başına bir örnek oluşturulur ve bu örneği bu istek içinde yeniden kullanılır.
Scoped servisler, bir istek içinde durumu korumak istediğimizde daha iyi bir seçenektir.


### Singleton:
Singleton kapsamı, istek ilk kez geldiğinde hizmetin tek bir örneğini oluşturur. Bundan sonra, sonraki her istek için aynı örneği kullanacaktır. Yeni istek, hizmetin yeni örneğini oluşturmaz, ancak mevcut örneği yeniden kullanır.
Uygulama genelinde durumu korumamız gereken yerlerde Singleton kullanırız. Uygulama yapılandırılması, Loglama servisleri veya verilerin önbelleğe alınması gibi.

1.Resimde ilk istek geldiğinde oluşan ID leri görmekteyiz.

![alt text](https://resimupload.org/images/2022/03/27/LifeCycleOfTheService.png)

Örnek Resim 2:

![alt text](https://resimupload.org/images/2022/03/27/LifeCycleOfTheService2.png)
