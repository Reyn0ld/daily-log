# Daily Log

**Daily Log** adalah aplikasi desktop sederhana berbasis **VB.NET** dan **Windows Forms** yang berfungsi sebagai alat untuk mencatat kegiatan sehari-hari, menyimpan catatan penting, dan memudahkan pengguna dalam mengelola informasi harian mereka.

---

## **Author**

Aplikasi ini dikembangkan oleh tiga author utama:

1. **Muhammad Farhan**  
2. **Raynold Lumbantobing**  
3. **Ajeng**

---

## **Fitur**

### **1. Menambahkan Catatan Baru**
- **Tombol New** memungkinkan pengguna membuat catatan baru.  
- Setiap catatan memiliki:
  - **ID** unik yang dihasilkan secara otomatis.  
  - **Title** atau judul catatan default.  
  - **Tanggal** pembuatan otomatis sesuai waktu sistem.  
  - **Description** yang dapat ditambahkan kemudian.  
- Semua data disimpan dalam file **JSON lokal** untuk memudahkan akses dan modifikasi.

---

### **2. Menampilkan Detail Catatan**
- Pengguna dapat mengklik judul catatan dari daftar catatan untuk membuka detailnya.  
- Sebuah **pop-up form** akan muncul dengan informasi:
  - **Judul** (ditampilkan dalam huruf tebal).  
  - **Tanggal** (dengan huruf kecil tipis).  
  - **Deskripsi** (ditampilkan dalam huruf sedang tipis).

---

### **3. Mengedit Catatan**
- Dalam pop-up form detail catatan, terdapat tombol **Edit**.  
- Saat tombol **Edit** ditekan:
  - Bagian judul dan deskripsi berubah menjadi **input box** (TextBox).  
  - Tombol **Edit** akan digantikan dengan tombol **Done**.  
- Setelah selesai mengedit, menekan **Done** akan:
  - Menyimpan perubahan ke file **JSON**.  
  - Mengembalikan tampilan awal (readonly text).

---

### **4. Menghapus Catatan**
- Terdapat tombol **Hapus** di samping tombol Edit.  
- Menekan tombol ini akan:
  - Menghapus catatan yang sedang ditampilkan dari file **JSON**.  
  - Menghapus catatan tersebut dari daftar utama.

---

## **Cara Install**

### **Langkah-langkah:**
1. Pastikan Anda memiliki **Windows OS** terinstal di komputer.  
2. Unduh file installer aplikasi Daily Log (.exe) dari link berikut:  
   [Unduh Installer Daily Log](#https://github.com/aan-cloud/daily-log-installer)
3. Jalankan file installer yang telah diunduh.  
4. Ikuti petunjuk instalasi hingga selesai.  
5. Setelah instalasi, aplikasi **Daily Log** akan muncul di menu Start atau desktop.

---

## **Cara Menggunakan Aplikasi**

1. **Menambahkan Catatan Baru**
   - Klik tombol **New** di bagian atas.  
   - Catatan baru akan muncul di daftar catatan dengan judul default.  
   - Buka catatan tersebut dan edit sesuai keinginan.

2. **Melihat Detail Catatan**
   - Klik salah satu judul catatan dari daftar.  
   - Detail catatan akan muncul di form pop-up.

3. **Mengedit Catatan**
   - Dalam form pop-up detail, klik tombol **Edit**.  
   - Ubah **judul** atau **deskripsi** sesuai kebutuhan.  
   - Klik **Done** untuk menyimpan perubahan.

4. **Menghapus Catatan**
   - Dalam form pop-up detail, klik tombol **Hapus**.  
   - Konfirmasi penghapusan jika diminta.

5. **Menutup Form Detail**
   - Klik tombol **X** di sudut kanan atas untuk menutup form detail.

---

## **Fitur Masa Depan**

Dalam pengembangan selanjutnya, kami berencana menambahkan fitur-fitur berikut:

1. **Edit Deskripsi dengan Ukuran Textbox Dinamis**  
   - Textbox deskripsi akan otomatis menyesuaikan ukuran berdasarkan panjang teks.  
   - Mendukung format **Markdown** untuk menulis teks dengan gaya yang lebih kaya.

2. **Koreksi Teks Menggunakan AI**  
   - Mengintegrasikan teknologi **AI** untuk menyarankan penulisan yang benar.  
   - Termasuk fitur **grammar correction** dan **rephrasing** teks deskripsi.

3. **Kompleks UI Design**  
   - Memperbarui desain antarmuka agar lebih modern dan ramah pengguna.  
   - Menambahkan elemen-elemen interaktif yang memperkaya pengalaman pengguna.

---

**Terima kasih telah menggunakan Daily Log!** 😊
