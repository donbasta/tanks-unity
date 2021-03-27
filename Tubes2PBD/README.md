# Tanks! Extended
##### Tugas Besar 2 IF3210 Pengembangan Aplikasi pada Platform Khusus

### Cara Kerja Aplikasi

Aplikasi yang dibuat bekerja dengan menggunakan Game Engine Unity dalam pelaksanaannya. Game Engine ini digunakan dalam seluruh bagian dari aplikasi. Berikut ini adalah penjelasan cara kerja dari fitur-fitur yang telah dibuat sesuai dengan spesifikasi.

##### Multiplayer Berbasis LAN
-

##### Setting dan Main Menu

Setting suara dan main menu diimplementasi dengan membuat scene baru yang terdiri atas panel dan button2 UI.

##### Perubahan Desain Map

Terdapat dua buah desain map, yang pertama menggunakan asset dari tanks tutorial dan yang kedua dari asset pada link https://assetstore.unity.com/packages/3d/props/gold-coins-1810?category=3d&price=0-0&free=true&q=map&orderBy=1

##### Cash Object

Cash object dibuat dengan terlebih dahulu menentukan lokasi spawn dari cash object (yang dalam hal ini adalah coin). Setelah semua titik spawn cash object ditentukan, maka tentukan pula interval dari kemunculan setiap koin. Kemunculan ini dapat berpola maupun random. Untuk mempermudah pengerjaan, kemunculan koin secara berpola. Setiap beberapa detik sekali, maka objek ini (yang menjadi lokasi spawn objek) akan membuat cash object. Pengaturan kemunculan ini diatur dengan pengulangan InvokeRepeating. Cash object memiliki Sphere Collider yang ditandai sebagai trigger. Jika objek mengenai objek lain (yang dalam hal ini adalah tank), maka objek tank akan ditambahkan uangnya sebesar 1 dan objek uang akan menghilang. Jumlah uang disimpan dalam data tank.

##### Senjata dan Pembeliannya

Senjata baru yang digunakan adalah peluru yang lebih besar dan memiliki kekuatan yang lebih besar. Pada dasarnya, senjata ini sudah disimpan di dalam object tank. Apabila pembelian dapat dilakukan, maka pembelian senjata akan terjadi. Senjata ini dapat dibeli dengan 5 koin. Senjata baru ini akan digunakan apabila pengguna yang bersangkutan sudah pernah melakukan transaksi dan senjata yang baru akan emnggantikan senjata yang lama.

##### NPC dan Pembeliannya
-

##### Animasi NPC

NPC menggukan asset box, dan animasinya menggunakan animation, di mana NPC tersebut akan bergerak pada jalur yang sudah ditentukan dan menembak secara periodik

##### Collision Tank dan NPC

Tank dan NPC keduanya merupakan rigid body dan akan terpental apabila bertabrakan.

##### Extra Map

[Sama dengan di atas]

##### Extra Game Mode
-

### Library dan Justifikasi
-

### Screenshot Aplikasi

![Credits](/img/credits.jpg)
![Done](/img/done.jpg)
![Menu](/img/MainMenu.jpg)

### Pembagian Kerja Anggota Kelompok

| NIM | Nama | Bagian yang Dikerjakan |
| --- | ---- | ---------------------- |
| 13518017 | Farras Mohammad Hibban Faddila | Setting dan Main Menu, Perubahan Desain Map, Animasi NPC |
| 13518140 | Hansel Grady daniel Thamrin | Cash Object, Senjata dan Pembeliannya |
| 13518134 | Muhammad Raihan Iqbal |  |
