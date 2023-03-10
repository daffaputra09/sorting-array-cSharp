# Aorting Array C#
### Melakukan sorting array pada bahasa pemgrograman c# (cSharp) menggunakan beberapa metode:
1. Bubble Sort
2. Insertion Sort
3. Merge Sort
4. Quick Sort
5. Selection Sort

---
### 1. Bubble Sort
Pengurutan **Bubble Sort** dilakukan dengan membandingkan masing-masing item dalam suatu list secara berpasangan, menukar item jika diperlukan, dan mengulaginya sampai akhir list secara berurutan, sehingga tidak ada lagi item yang dapat ditukar.
### 2. Insertion Sort
Pengurutan **Insertion Sort** pada dasarnya memilih data yang akan diurutkan menjadi dua bagian, yang belum diurutkan dan yang sudah diurutkan. Elemen pertama diambil dari bagian array yang belum diurutkan dan kemudian diletakkan sesuai posisinya pada bagian lain dari array yang telah diurutkan. Langkah ini dilakukan secara berulang hingga tidak ada lagi elemen yang tersisa pada bagian array yang belum diurutkan.
### 3. Merge Sort
Pengurutan **Merge Sort** merupakan algoritma yang menggunakan cara `divide-and-conquer` dimana memecah kemudian menyelesaikan setiap bagian dan menggabungkan nya kembali. **Cara Kerja Merge Sort:**
```
- Divide : Memilah elemen – elemen dari rangkaian data menjadi dua bagian.
- Conquer : Conquer setiap bagian dengan memanggil prosedur merge sort secara rekursif
- Kombinasi : Mengkombinasikan dua bagian tersebut secara rekursif untuk mendapatkan rangkaian data berurutan
```
### 4. Quick Sort
Pengurutan **Quick Sort** menggunakan metode rekursi sampai habis. Prinsipnya memilih satu urutan untuk menjadi pivot dan membagi data menjadi dua bagian yang sama (kiri dan kanan).

### 5. Selection Sort
Pengurutan **Selection Sort** adalah algoritma yang memilih elemen dengan nilai terendah kemudian menukar elemen yang terpilih dengan elemen ke-i dimana i dimulai dari 1 ke n, dimana n adalah jumlah total elemen dikurangi 1.

---
**Sumber:**
* https://phpmu.com/macam-macam-algoritma-sorting-dan-implementasi-dengan-php/
* https://se.ittelkom-pwt.ac.id/2021/06/10/jenis-jenis-algoritma-sort/
* https://kodedasar.com/blog/algoritma-sorting
