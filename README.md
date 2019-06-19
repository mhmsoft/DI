# DI
Dependecy Injection(DI) Nedir?
#Uygulamalar geliştirilirken bir sınıfa ait bilgilerin başka bir sınıfta kullanılması gerektiğinde ilk sınıfa ait bilgileri bir nesneye atanır ve diğer sınıfa yönlendirilir. Ya da bazı durumlarda new anahtar kelimesi ile kullanım yerinde o sınıfa ait bir nesne yaratılır.
Nesnelerin birbiri ile ilişkili olduğu bu tip durumlar iyi yönetilmez ya da iyi tasarlanmaz ise uygulama dar boğaza sürüklenmeye başlar. Yani uygulama büyüdükçe yapılan en ufak bir geliştirme uygulamanın birçok yerini etkileyebilir. Böyle durumlarda geliştirmeye devam etmek ya da yeni modüller eklemek zorlaşacak, belki de imkansız olduğu noktalar oluşacaktır.
Bir nesne yapması gereken işleri başka bir nesnenin yardımıyla yapıyor ya da o nesne olmadan yapamıyorsa, söz konusu nesne diğer nesneye bağımlıdır denilir. Uygulamalarımız geliştirmeye açık olmalıdır. Bunun için de nesneler arası bağlar mümkün olduğunda gevşek, yönetilebilir şekilde tasarlanmalıdır. Bir nesne ve/veya bir sınıf üzerinde değişiklik yapıldığında sınıf ile ilişkili ya da o sınıfın nesnesini kullanan tüm diğer sınıflar ve modüller bu değişiklikten etkilenmemelidir.
Dependency Injection, bir nesne yaratma / atama metodolojisidir. Yani nesneye erişme tasarımıdır. Bu tasarım ne kadar esnek olursa uygulama gelişime o kadar açık olacaktır. Yine bu metodoloji bizi doğru tasarım kullanımına zorlayacağından modülarite ve kod okuma kalitesini artıracaktır.
Dependency Injection ile nesne atamaları dinamik hale getirilmektedir. Bir başka ifade ile Dependency Injection ile uygulamanın çalışırken kullanacağı nesneler dışarıdan enjekte edilmektedir. Bu sayede ileride oluşabilecek herhangi bir değişiklikte uygulamanın tümünün değil belirli bölümlerinin değiştirilmesi yeterli olacaktır.
SOLID yazılım mimarisi prensiplerinden D maddesini oluşturur. 
Uygulama içerisindeki herhangi bir sınıf, kullanacağı nesnelerin davranışlarını bilmeden ve o davranışlardan doğrudan etkilenmeden o nesneyi kullanabilmelidir. Bu sınıf ilgili nesneye çalışma zamanında erişmeli ve ihtiyacı olan bilgileri elde etmelidir. Nesne kullanıldığı sınıf içerisinde doğrudan tanımlanmış olmamalıdır.
Bir örnekle yazdıklarımızı pratikleştirmeye çalışalım.
Yeni bir ASP.Net MVC projesi oluşturalım. Ve Projemiz üzerinde sağ tuş yapıp Manage Nuget Package ‘ a tıklayarak oradan Unity.MVC5 containeri projemize dahil ederek Dependecy Injection projemizi inject edeceğimiz configrasyonu yapacağız.
Projemize Unity.MVC5 Install ettikten sonra AppStart klasörünün içerisine UnityConfig.cs isminde bir class dosyasının dahil olduğunu göreceğiz.

