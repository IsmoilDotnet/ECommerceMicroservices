# EcommerceMicroservices
<h1>Singleton</h1>
Bu o'z ichiga yagona nusxa obyektni saqlaydigan dizayn shablon. Bu, biror obyektni yagona marta yaratib, keyin barcha so'rovlarda o'sha obyektga o'tkazadi.

<h1>Sealed</h1>
Bu klassni miras olishni cheklash uchun mo'ljallangan modifikator. Agar klass sealed bo'lsa, undan miras ololmaydi.

<h1>Constructor private bo'lsa</h1> 
Agar bir klassning constructor-i private bo'lsa, ushbu klass faqat o'z ichidagi metodlardan yoki boshqa klasslar orqali yaratilishi mumkin.

<h1>CQRS ning odatiy usuldan ustunligi</h1>
CQRS (Command Query Responsibility Segregation) - bu arxitektural dizayn shabloni, komandalarni (command) va so'rovlarni (query) ajratib olishni tavsiya qiladi. Bu, kodni bo'limlarga bo'lish, qodirlik va qo'llanishni oshirishga yordam beradi. Murojaatlar va o'zgarishlarni ajratib turish, ma'lumotni parallel ishlab chiqish, optimallashtirish imkoniyatini beradi.

<h1>Dependency Injection container</h1>
Bu, dastur ichidagi obyektlarni yaratish, ulash va ma'lumot almashish jarayonlarini avtomatlashtirishga yordam beruvchi vosita. Bunday konteynerlar, dasturchilarga obyektlarni birlashtirish, boshqarish va ulashning vositalarini taqdim etishga yordam beradi.

<h1>IOC container nima?</h1>
Dependency Injection container? Agar bir yoki bir nechta obyektlar oz ichiga birinchi jarayonni avtomatik ravishda boshqarib, ularni injeksion qilish uchun vosita sifatida ishlatilsa, bunaqa vosita IOC (Inversion of Control) konteyner deb ataladi. Bu, boshqa komponentlar tomonidan bir komponentning birlashishini boshqarishni o'z ichiga oladi. Dependency Injection konteyneri shuni qayta yoritadi, ya'ni obyektlarni injeksion qilish va ularga murojaat qilishning yopiq tuzilishini ta'minlaydi.

<h1>Constructor:</h1>
Constructor, bir klass yaratilganda avtomatik ravishda ishga tushadi va klassning obyektini yaratish uchun ishlatiladi. Bu, asosiy qismni o'z ichiga oladi va avtomatik ravishda bajariladi.
