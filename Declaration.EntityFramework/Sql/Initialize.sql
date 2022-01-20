USE [Covid19Declaration]
GO
SET IDENTITY_INSERT [Covid_Declaration].[DeclarationTypes] ON 
GO
INSERT [Covid_Declaration].[DeclarationTypes] ([DeclarationTypeId], [DeclarationTitle], [Type]) VALUES (1, N'Pre-Travel Declaration', N'Travel Declaration')
GO
INSERT [Covid_Declaration].[DeclarationTypes] ([DeclarationTypeId], [DeclarationTitle], [Type]) VALUES (2, N'Event Declaration', N'Event')
GO
INSERT [Covid_Declaration].[DeclarationTypes] ([DeclarationTypeId], [DeclarationTitle], [Type]) VALUES (3, N'Mass Involvement Declaration', N'Mass Involvement')
GO
SET IDENTITY_INSERT [Covid_Declaration].[DeclarationTypes] OFF
GO
SET IDENTITY_INSERT [Covid_Declaration].[DeclarationDetails] ON 
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (1, N'Employee went out and returned from outside Batam region due to compassionate (funeral or hospitalized) related to Family (Spouse, Children, Parents and Parents in law)', N'Karyawan keluar dan kembali dari luar wilayah Batam karena kemalangan (pemakaman atau rawat inap) terkait dengan Keluarga (Pasangan, Anak, Orang Tua dan Mertua)', 0, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 1, N'Outside Batam 
(Within Riau 
Islands)', 1, 1)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (2, N'Employee went out and returned from outside Batam region due to personal or family reason excluding compassionate', N'Karyawan keluar dan kembali dari luar wilayah Batam karena alasan pribadi atau keluarga diluar dari kemalangan', 0, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 1, N'Outside Batam 
(Within Riau 
Islands)', 1, 1)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (3, N'Employee''s House members who live together with employee , then go outside Batam region and come back to Batam region', N'Anggota Rumah Karyawan yang tinggal bersama dengan karyawan, kemudian keluar wilayah Batam dan kembali ke wilayah Batam', 1, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul><p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 1, NULL, 0, 1)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (4, N'Employee''s visitors from out side batam who stay at employee''s house ', N'Tamu/pengunjung karyawan dari luar batam yang menginap di rumah karyawan', 1, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 1, NULL, 0, 2)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (5, N'Employee''s House members or Visitors who live/stay together at employee''s house is identified as close contact with positive case from other company, schools, events, community, etc.

Note, the close contact had been verified by authority.
', N'Anggota rumah karyawan atau tamu/pengunjung yang tinggal serumah dengan karyawan  teridentifikasi kontak dekat dengan kasus positive dari perusahaan lain, sekolah, acara, komunitas, dan lainnya.

Catatan : status teridentifikasi kontak dekat sudah di konfirmasi oleh pihak pemerintah (satgas)
', 1, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 1, NULL, 0, 2)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (6, N'Event hosted by Employee or any house members  which people crowd likely to happen which attended for more than 10 peoples
Example : Married, family gathering, birthday party which invite others from different house etc', N'Acara yang diselenggarakan oleh Karyawan atau anggota rumah lainnya yang kemungkinan besar akan terjadi keramaian dan dihadiri lebih dari 10 orang tamu undangan
Contoh: Menikah, kumpul keluarga, pesta ulang tahun yang mengundang orang lain dari rumah berbeda dll', 1, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 1, NULL, 0, 3)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (7, N'Employee attend as a Participant to event which people crowd likely to  happen  (live event) which attended for more than 50 peoples and more for more than 3 hours.', N'Karyawan hadir sebagai peserta/tamu undangan pada acara yang kemungkinan besar akan terjadi kerumunan dan keramaian dan dihadiri lebih dari 50 orang dan lebih dari 3 jam.', 0, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 1, NULL, 0, 3)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (8, N'Employee went out and returned from outside Batam region due to compassionate (funeral or hospitalized) related to Family (Spouse, Children, Parents and Parents in law)', N'Karyawan keluar dan kembali dari luar wilayah Batam karena kemalangan (pemakaman atau rawat inap) terkait dengan Keluarga (Pasangan, Anak, Orang Tua dan Mertua)', 0, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 0, N'Domestic 
(Outside Riau 
Islands)
', 1, 1)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (9, N'Employee went out and returned from outside Batam region due to compassionate (funeral or hospitalized) related to Family (Spouse, Children, Parents and Parents in law)', N'Karyawan keluar dan kembali dari luar wilayah Batam karena kemalangan (pemakaman atau rawat inap) terkait dengan Keluarga (Pasangan, Anak, Orang Tua dan Mertua)', 0, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 0, N'Overseas', 1, 1)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (10, N'Employee went out and returned from outside Batam region due to personal or family reason excluding compassionate', N'Karyawan keluar dan kembali dari luar wilayah Batam karena alasan pribadi atau keluarga diluar dari kemalangan', 0, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 0, N'Domestic 
(Outside Riau 
Islands)
', 1, 1)
GO
INSERT [Covid_Declaration].[DeclarationDetails] ([DeclarationDetailId], [Detail], [Detail_Id], [IsRelationshipRequired], [Quarantine], [PCR], [Quarantine_Id], [PCR_Id], [ShowList], [Remark], [WithVaccineStatus], [DeclarationType_DeclarationTypeId]) VALUES (11, N'Employee went out and returned from outside Batam region due to personal or family reason excluding compassionate', N'Karyawan keluar dan kembali dari luar wilayah Batam karena alasan pribadi atau keluarga diluar dari kemalangan', 0, N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', N'<p>No quarantine</p>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>
<p>~</p>
<ul>
<li>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s,</li>
</ul>', N'<p>No PCR / antigen</p>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
</ul>
<p>~</p>
<ul>
<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh nisl condimentum id venenatis a condimentum vitae. Auctor elit sed vulputate mi sit amet mauris. </li>
<li>Sit amet consectetur adipiscing elit pellentesque. Egestas maecenas pharetra convallis posuere morbi leo. </li>
<li>Pretium quam vulputate dignissim suspendisse in est ante in. At varius vel pharetra vel turpis nunc eget lorem.</li>
</ul>', 0, N'Overseas', 1, 1)
GO
SET IDENTITY_INSERT [Covid_Declaration].[DeclarationDetails] OFF
GO
INSERT [Covid_Declaration].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202201200603208_initialization', N'Declaration.EntityFramework.Migrations.Configuration', 0x1F8B0800000000000400ED5DDD6EDDB811BE2FD0771074D52EB23EB6F7666BD8BB884FE2C2681CA73E4EDA3B8396E86335FA392B518E8D459FAC177DA4BE4249FDF25722454A3969170B2C7C48F1236738331C92C3C97FFEF5EFD39F9F93D87B82791165E9997F7470E87B300DB2304AB7677E891EBEFFD1FFF9A7DFFFEEF46D983C7B9FDAEF7E20DFE1966971E63F22B43B59AD8AE01126A03848A220CF8AEC011D0459B20261B63A3E3CFCD3EAE8680531848FB13CEFF4A64C5194C0EA07FEB9CED200EE5009E2AB2C8471D194E39A4D85EABD07092C76208067FE1B18C42007088FE3E02D46412F1739AEFD92E59F7DEF751C013CA40D8C1F7C0FA46986AA0F4F3E167083F22CDD6E76B800C4B72F3B88BF7B0071011B424EFACF75693A3C2634ADFA862D545016284B0C018F7E6898B4E29B4F62B5DF3111B3B16614A1BA6225C3C537108128F63DBED793759C9316832C6F7E1F0878AFBC8156AF3A49C20247FE7BE5ADCB1895393C4B618972809B7F28EFE328F80B7CB9CD3EC3F42C2DE39826091385EB98025CF421CF7630472F37F04145E865E87B2B1668C52375384320356F2E53F4C3B1EFBDC7C303F731EC648AE2E3066539FC334C214680E1078010CCB1485C86B0E28A301CA1F37A7EEAFEB01863D5F4BD2BF0FC0EA65BF478E6E33F7DEF227A86615BD28CE1631A614DC68D505E42BD6EEE7ACA66EBE9B2B88171C59AE231DADDC05FCA28875DB7E7591643904A583A8CFAD712CF1066680A6727E0C3FA66F63E7A729698124CD112DD6C1EB32FEFA202D9CEF50D367FC4DCCF3CDCBF45E8F11308023C091BACCB65613CEEF7E029DA56A2AEB62817599E60645A27EA15EC80FBE84E62B42FF22CB9C9621151FCF8EE16E45B48789FE9B6D864651E4CA38A306A8C28F28DD86BA1A04AF1F51059AA2632BA4E57FD22A9BB7412B6B95B3809DA1E2E9B960BE6924BE53908B770013B46FEBFC0825C60F3DF3880731B660472F406F3BCED89FC7D1B112A0D4DF3DB347482739B832718DF40502C40FE42EBC9A6BC4F2222D2F3CB0E667BDD9BF5445C81285D5214EB05B7EA8B5D7467EBF1354220784CB0895942CF3045E3267164C0C1E734FB12436CECE4BA3661BD6E1D8AF9DD9076F1D57743DA155E972C9A06B9674517DD090B7A4FCDD07782E331F8B195CB41235BFA1B34D4BE381B533C8C6577E006DECC1E780EF41CD77EB8EB0E75F735F3291F6F45B434D5D6DFAF99E9CADF276DF64505B96159FAFC2DC45750D0DB08C5F36BD8D7D3AA6E8FBCC4D67A60A91EDB8D4F52B5B709C6B885C92EAEDC1A2B4563B0F645CDF67DA55B467BF0CEE41F3098DFDB5E672972EFD51B48F32ECE5EA0BD20D730FB22C3DD218BA9208F9FCE1C1DFFA8351DFBE87455F6668143A11DC8D1327BD512FF8AB27C11EEB59D5D2DC1C4D7BB5D9E3DC165286B3B5B84B2F68469CA199CBE5D7B2697F5D8D6BCCBB6B6B68D82DA17FBB6EF6B74C7B32B5814603BBF04936534CFE2782985090871CBD8EC96951B0482CFB73908E6EFF36301F305AE28B042D53A3F8F0DD8C0342416CDDE045048BF59003D0BB094FF7C03B17A444BF81A5D4FEBF5727D9D2FD019966E37F76AE759F8F295F733C4721596DA5E61FCA6E77A7ABEC81A486664868E5452F5BA28B220AAD8233F32965C2FB1E37F9B869EF15D534D9AE4360B138AA52BDA6179C2A33DF3BF13F865D25F772524EDAFBD2D637B3C3C3838E27947716998798367E92A3AF40ED67B12D8EB277D7EE9DD9E694FCD91CFABF43566690C11F46A9F11BBAAA0084028CA3C16C6902DC15600E6440D418CCD6A81ED4A9422D164446910ED406C401087611E5D4386DB75CCD7E0FD3FF697F0B80DA6D2C988BA8E39C68EF1D14096358EAF353473F42C5B2A6FF581FE98629AF639C51C7CA7690B6AF34A5C02CC7198F7A70D18A8863FAFFC85672459B2B1D16F56EDA231DE3C95047C03D1C005446FDFD5A409CC53C28E00D6F660048EBBF717F0583BA63FB68A4FC3E3ABE5670492B992900172F71FA370F5C1B01CA93D7B1E03A14E60A440CC61CF0818B5979361319BC611A8C6D914309A72AE35A523D21954C5AD50EDB4835D78D338C51FE9A8E5754030BC53BC0F397AA7B8FCDAC8324F83B1C317F8224FF59D14733785A29553FF01566A39269A7334817F3AF7B48392A9B53C4E5D20E5743736504F3EC7D6435702DA6E32BA55B0AB3B5DD52FC79A82D395E289D9E915D8EDF07E877A72D694789BFABDD9FAFB8DF9FBABA4C6580585E4195637DAAE27BC4D045BC8D59283D7105E4479414E10C03D203BAE7598089F49D77C85756DBB542EEBE2FCB606B86D4AFE169A0BFBFD51BBD9731A37DA921BAD8A0F704836440C8F3C1104F82B9D175BEB2C2E9354FB5DD8307EBD80B09032A7671CE54E1C5B57AC8FA57A554503ABBED1EF857E654523D3E5FA68D5432A1AA62A98321A81875C95D19804B0B64C1FA57FE944E3F4A5FA486D6C3A8DD396E9A3489E32D180926A11FB74C529ACB049148C85B00B67CD90A9919AC53CC9BC1033E32447D0304D0346C94CDCBAD00A1A4D11A83184531F04D22075898949A39E0AB0B45115068AD4BF4C6134A92FD6C7EADEA6D0485DA13E0EFB368506636B965672EA7D09C3ABBED8601EA91724CC3452E5FA68C223121A52A8D4C7953C16A19125D5FAD8F4B3101A942E3792E3E6E50727C64DA9C1B8F8D71FCCE0F8CABD31E3ECEECC951D678E74CC8DF87073A5ABC5BB5586AEA37BFB6F6FB7C53703AC2DE26BF746AE843DEA0C2E4245B2958B2047D0109136945E2126F2607D5DEC3ADA57055DD71A2C8B82D8EC99A870E7AFAE04853DB535179391F6F35821C9DC1B4F781787C2791B75A13E4E17D740E374857B243EED79BB3BC9694EE9A7088DAAE9FEEF119A5069C60B4F8C8F4EFA4068D680F5E526924CC73AB3E24CD798235E09A4B235067E1F13B5CC387D4C8D39A23846B6C67C0722D9677155FBA3D5CC059833CDA6AFCD2668F760F379560431AE985150A1D6CCBED301C4BC99A7EB4CF6416438126DA0CA27504F87024B19407FA08FDF86FDD2906D993E4A17D54BC374857BA353CC3DB02B95A26F8FCD356AB0F53C0AE5CA3DA2C270D93D59573C018BC4BE4AD148C504BC7325E0B919621F31CBB0AD2B353814A5436619A787AED81BA5A9231B5C698B144D434F14EDE6D1107B57B28F5EE50DAB0A69EED9652FAB956715AA889449D7173220C3FB0A72913F9CCB411D7022F2D8D19DACD8A53C38911ABB0BB29471938ECFF306078E0D541855D19197058931EF82AEAD39C60754D888B1327E65D2199B14C9382A6078CE47C25FCC275DE384EE4EF2B93B291E89B6994D3B6717693DD68D8BB31026C47FD2AD094D49F7BB0B136A4274C6D3530B313BF527BE8799F21485245E67F35220981C900F0E36BFC4EBB876E2DA0FAE401A3DC002D56F5BFCE3C3A3632EB1F5FE24995E1545C8E89F4EA66976F6F6228B73442660F4B58EE1932D367173FA04F2E011E47F48C0F31F69AC49C999ADD0861330DF93AB5DEBE4CB5603A4122C5BE1489328DB8ECC15149F0C790ADFD9C49556C351263B9E322E0D234E299EF03CE1320DE1F399FF6B8576E25DFE9D0710015F79D739369E27DEA1F7CF61D22727FAB5B35BCED2E8CE62ABB8DC2C569254EFBC9C583D21EDA89DC6F1596E43FC377290E576328E2CCBAD15890E0D8290ADD66E2E858CB49399A6C8486B353C65D6592B5431B3ACADFC32D9632B4BE02677AC6C32F454546B033AD9D8AB416730F8EA68A025DE93CFE483AA5610B37950F3DB380397A57D93A73635009D9CF8D36EFD576D5E27A7D59C5B5E985C80569336F7440D04D07CB38AEB8EFB5CB6182B2C2E03C93C93290B6C593635614B97989CF06BD93D26BBA0A553CD6710B494AE9D9025D009E0952B8265D9FE9C003A1BA1346B9FA67B3C2D6BDFFF868D5465C2B3367162B63B3B811132DAD9D90275D63A2B5C36339D1514977DCEB52C2B8339BE595176B9480B69DBDCA0F5D9D2DCE09D3B02E453AC4D3E5790A4589BC3C19144587CB362EBCCA6F159C81C307EA64C63DC3FC73931C5970ABD4EA121C7D64B573629B195CE6BFD49B7729E4932ABF147B91A63D08D195920A1D5A4E46C16C2E034419A3C5B8A455E385BC19C22120EB3ABFD1FA6519B2759DA1403EA5E9AC413BDF1295587EE4C3171D30CAD7E38917351E38268BAFD129FA48697819154727A99E4EA301AD2DD5314D20CC082547B061A998406C652DBD3A191D45F188DA3F9A77D4746C19A5161086CF578FF8369B0C6D2DCE964B933620169323E0A2EF19D3006AE7E7C047CAABDD1FEDB747992AEDB2A9D5EBB8C7C631D3269F5C44E996A8D8ED92C7E239D3379F884BE99DAF1AED99C7F233D8F64F51BEFED1B49FFC75A3645D8AA68B307BCC08148EE9178480D562D94D0CF82A801879402194CF0F92DE6E91BCAC6A72B3F5364D14DCE3D3168167B1F654A0E67EA5F6F60116D7B0812209CC280F13BBA6F2ED387ACF58CB811B59FF0712298B4103B25AF73143D8000E1EA00164595DDFC1388CBCA60DFC3F032BD2ED1AE44986498DCC74C5A76E2460DF55F251664C77C7A5D59E2C2050978981139CFBA4ECFCB280EBB715F480E4F1510C43F6B4E7CAA236372F2B37DE990DE677CCA361550C3BECEADEC56D7EB74039EE094B1616BFE0E6E41F0D2C63EAB41C6278265FBE99B086C7390140D46DF1EFFC4321C26CF3FFD172E2A49FA00890000, N'6.4.4')
GO
SET IDENTITY_INSERT [Covid_Declaration].[EmailTemplates] ON 
GO
INSERT [Covid_Declaration].[EmailTemplates] ([Id], [Title], [Subject], [Content]) VALUES (1, N'Confirm notification', N'none', N'<!doctype html>
<html>
<head>
<meta name="viewport" content="width=device-width">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Simple Transactional Email</title>
<style>
/* -------------------------------------
INLINED WITH htmlemail.io/inline
------------------------------------- */
/* -------------------------------------
RESPONSIVE AND MOBILE FRIENDLY STYLES
------------------------------------- */
@media only screen and (max-width: 620px) {
table[class=body] h1 {
font-size: 28px !important;
margin-bottom: 10px !important;
}
table[class=body] p,
table[class=body] ul,
table[class=body] ol,
table[class=body] td,
table[class=body] span,
table[class=body] a {
font-size: 16px !important;
}
table[class=body] .wrapper,
table[class=body] .article {
padding: 10px !important;
}
table[class=body] .content {
padding: 0 !important;
}
table[class=body] .container {
padding: 0 !important;
width: 100% !important;
}
table[class=body] .main {
border-left-width: 0 !important;
border-radius: 0 !important;
border-right-width: 0 !important;
}
table[class=body] .btn table {
width: 100% !important;
}
table[class=body] .btn a {
width: 100% !important;
}
table[class=body] .img-responsive {
height: auto !important;
max-width: 100% !important;
width: auto !important;
}
}

/* -------------------------------------
PRESERVE THESE STYLES IN THE HEAD
------------------------------------- */
@media all {
.ExternalClass {
width: 100%;
}
.ExternalClass,
.ExternalClass p,
.ExternalClass span,
.ExternalClass font,
.ExternalClass td,
.ExternalClass div {
line-height: 100%;
}
.apple-link a {
color: inherit !important;
font-family: inherit !important;
font-size: inherit !important;
font-weight: inherit !important;
line-height: inherit !important;
text-decoration: none !important;
}
#MessageViewBody a {
color: inherit;
text-decoration: none;
font-size: inherit;
font-family: inherit;
font-weight: inherit;
line-height: inherit;
}
.btn-primary table td:hover {
background-color: #34495e !important;
}
.btn-primary a:hover {
background-color: #34495e !important;
border-color: #34495e !important;
}
}
</style>
</head>
<body class="" style="background-color: #f6f6f6; font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;">
<span class="preheader" style="color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0;">[%PreHeader%]</span>
<table border="0" cellpadding="0" cellspacing="0" class="body" style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background-color: #f6f6f6;">
<tr>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top;">&nbsp;</td>
<td class="container" style="font-family: sans-serif; font-size: 14px; vertical-align: top; display: block; Margin: 0 auto; max-width: 580px; padding: 10px; width: 580px;">
<div class="content" style="box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px;">

<!-- START CENTERED WHITE CONTAINER -->
<table class="main" style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background: #ffffff; border-radius: 3px;">

<!-- START MAIN CONTENT AREA -->
<tbody>
<tr>
<td class="wrapper" style="font-family: sans-serif; font-size: 14px; vertical-align: top; box-sizing: border-box; padding: 20px;">
<table style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;" border="0" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top;">
<p style="font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; margin-bottom: 15px;">Declaration form has just been [%status%],</p>
<p style="font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; margin-bottom: 15px;">Declaration type:<br />[%DeclarationType%]</p>
</td>
</tr>
</tbody>
</table>
<table style="width: 710px;">
<tbody>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_badge%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Badgeid%]</td>
</tr>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_Name%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Name%]</td>
</tr>
 <tr>
<td style="width: 151.646px;padding:5px 10px;">Department</td>
<td style="width: 360.354px;padding:5px 10px;">[%Dept%]</td>
</tr>
[%Relationship%]
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_Destination%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Destination%]</td>
</tr>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_StartDate%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%StartDate%]</td>
</tr>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_EndDate%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%EndDate%]</td>
</tr>
 [%TravelReason%]
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_Remark%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Remark%]</td>
</tr>
</tbody>
</table>
   <br>
<table>
<tbody>
</tbody>
</table>
</td>
</tr>
<!-- END MAIN CONTENT AREA --></tbody>
</table>

<!-- START FOOTER -->
<div class="footer" style="clear: both; margin-top: 10px; text-align: center; width: 100%;">
<table style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;" border="0" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<td class="content-block powered-by" style="font-family: sans-serif; vertical-align: top; padding-bottom: 10px; padding-top: 10px; font-size: 12px; color: #999999; text-align: center;">COVID-19 Declaration System</td>
</tr>
</tbody>
</table>
</div>
<!-- END FOOTER --> <!-- END CENTERED WHITE CONTAINER -->
</div>
</td>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top;">&nbsp;</td>
</tr>
</table>
</body>
</html>')
GO
INSERT [Covid_Declaration].[EmailTemplates] ([Id], [Title], [Subject], [Content]) VALUES (2, N'Submit to Approval', NULL, N'<!doctype html>
<html>
<head>
<meta name="viewport" content="width=device-width">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Simple Transactional Email</title>
<style>
/* -------------------------------------
INLINED WITH htmlemail.io/inline
------------------------------------- */
/* -------------------------------------
RESPONSIVE AND MOBILE FRIENDLY STYLES
------------------------------------- */
@media only screen and (max-width: 620px) {
table[class=body] h1 {
font-size: 28px !important;
margin-bottom: 10px !important;
}
table[class=body] p,
table[class=body] ul,
table[class=body] ol,
table[class=body] td,
table[class=body] span,
table[class=body] a {
font-size: 16px !important;
}
table[class=body] .wrapper,
table[class=body] .article {
padding: 10px !important;
}
table[class=body] .content {
padding: 0 !important;
}
table[class=body] .container {
padding: 0 !important;
width: 100% !important;
}
table[class=body] .main {
border-left-width: 0 !important;
border-radius: 0 !important;
border-right-width: 0 !important;
}
table[class=body] .btn table {
width: 100% !important;
}
table[class=body] .btn a {
width: 100% !important;
}
table[class=body] .img-responsive {
height: auto !important;
max-width: 100% !important;
width: auto !important;
}
}

/* -------------------------------------
PRESERVE THESE STYLES IN THE HEAD
------------------------------------- */
@media all {
.ExternalClass {
width: 100%;
}
.ExternalClass,
.ExternalClass p,
.ExternalClass span,
.ExternalClass font,
.ExternalClass td,
.ExternalClass div {
line-height: 100%;
}
.apple-link a {
color: inherit !important;
font-family: inherit !important;
font-size: inherit !important;
font-weight: inherit !important;
line-height: inherit !important;
text-decoration: none !important;
}
#MessageViewBody a {
color: inherit;
text-decoration: none;
font-size: inherit;
font-family: inherit;
font-weight: inherit;
line-height: inherit;
}
.btn-primary table td:hover {
background-color: #34495e !important;
}
.btn-primary a:hover {
background-color: #34495e !important;
border-color: #34495e !important;
}
}
</style>
</head>
<body class="" style="background-color: #f6f6f6; font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;">
<span class="preheader" style="color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0;">[%PreHeader%]</span>
<table border="0" cellpadding="0" cellspacing="0" class="body" style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background-color: #f6f6f6;">
<tr>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top;">&nbsp;</td>
<td class="container" style="font-family: sans-serif; font-size: 14px; vertical-align: top; display: block; Margin: 0 auto; max-width: 580px; padding: 10px; width: 580px;">
<div class="content" style="box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px;">

<!-- START CENTERED WHITE CONTAINER -->
<table class="main" style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background: #ffffff; border-radius: 3px;">

<!-- START MAIN CONTENT AREA -->
<tbody>
<tr>
<td class="wrapper" style="font-family: sans-serif; font-size: 14px; vertical-align: top; box-sizing: border-box; padding: 20px;">
<table style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;" border="0" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top;">
<p style="font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; margin-bottom: 15px;">New declaration form has just been submitted,</p>
<p style="font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; margin-bottom: 15px;">Declaration type:<br />[%DeclarationType%]</p>
</td>
</tr>
</tbody>
</table>
<table style="width: 710px;">
<tbody>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_badge%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Badgeid%]</td>
</tr>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_Name%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Name%]</td>
</tr>
  <tr>
<td style="width: 151.646px;padding:5px 10px;">Department</td>
<td style="width: 360.354px;padding:5px 10px;">[%Dept%]</td>
</tr>
[%Relationship%]
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_Destination%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Destination%]</td>
</tr>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_StartDate%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%StartDate%]</td>
</tr>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_EndDate%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%EndDate%]</td>
</tr>
  [%TravelReason%]
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_Remark%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Remark%]</td>
</tr>
</tbody>
</table>
   <br>
<table>
<tbody>
<tr>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top; background-color: #478f7c; border-radius: 5px; text-align: center;"><a style="display: inline-block; color: #ffffff; background-color: #478f7c; border: solid 1px #478f7c; border-radius: 5px; box-sizing: border-box; cursor: pointer; text-decoration: none; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-transform: capitalize; border-color: #478f7c;" href="[%ApproveUrl%]" target="_blank" rel="noopener">  Approve</a></td>
  
 <td style="font-family: sans-serif; font-size: 14px; vertical-align: top; background-color: #E30034; border-radius: 5px; text-align: center;"><a style="display: inline-block; color: #ffffff; background-color: #E30034; border: solid 1px #E30034; border-radius: 5px; box-sizing: border-box; cursor: pointer; text-decoration: none; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-transform: capitalize; border-color: #E30034;" href="[%RejectUrl%]" target="_blank" rel="noopener">Reject</a></td>
</tr>
</tbody>
</table>
</td>
</tr>
<!-- END MAIN CONTENT AREA --></tbody>
</table>

<!-- START FOOTER -->
<div class="footer" style="clear: both; margin-top: 10px; text-align: center; width: 100%;">
<table style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;" border="0" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<td class="content-block powered-by" style="font-family: sans-serif; vertical-align: top; padding-bottom: 10px; padding-top: 10px; font-size: 12px; color: #999999; text-align: center;">COVID-19 Declaration System</td>
</tr>
</tbody>
</table>
</div>
<!-- END FOOTER --> <!-- END CENTERED WHITE CONTAINER -->
</div>
</td>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top;">&nbsp;</td>
</tr>
</table>
</body>
</html>')
GO
INSERT [Covid_Declaration].[EmailTemplates] ([Id], [Title], [Subject], [Content]) VALUES (3, N'Submit to Superior', NULL, N'<!doctype html>
<html>
<head>
<meta name="viewport" content="width=device-width">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Simple Transactional Email</title>
<style>
/* -------------------------------------
INLINED WITH htmlemail.io/inline
------------------------------------- */
/* -------------------------------------
RESPONSIVE AND MOBILE FRIENDLY STYLES
------------------------------------- */
@media only screen and (max-width: 620px) {
table[class=body] h1 {
font-size: 28px !important;
margin-bottom: 10px !important;
}
table[class=body] p,
table[class=body] ul,
table[class=body] ol,
table[class=body] td,
table[class=body] span,
table[class=body] a {
font-size: 16px !important;
}
table[class=body] .wrapper,
table[class=body] .article {
padding: 10px !important;
}
table[class=body] .content {
padding: 0 !important;
}
table[class=body] .container {
padding: 0 !important;
width: 100% !important;
}
table[class=body] .main {
border-left-width: 0 !important;
border-radius: 0 !important;
border-right-width: 0 !important;
}
table[class=body] .btn table {
width: 100% !important;
}
table[class=body] .btn a {
width: 100% !important;
}
table[class=body] .img-responsive {
height: auto !important;
max-width: 100% !important;
width: auto !important;
}
}

/* -------------------------------------
PRESERVE THESE STYLES IN THE HEAD
------------------------------------- */
@media all {
.ExternalClass {
width: 100%;
}
.ExternalClass,
.ExternalClass p,
.ExternalClass span,
.ExternalClass font,
.ExternalClass td,
.ExternalClass div {
line-height: 100%;
}
.apple-link a {
color: inherit !important;
font-family: inherit !important;
font-size: inherit !important;
font-weight: inherit !important;
line-height: inherit !important;
text-decoration: none !important;
}
#MessageViewBody a {
color: inherit;
text-decoration: none;
font-size: inherit;
font-family: inherit;
font-weight: inherit;
line-height: inherit;
}
.btn-primary table td:hover {
background-color: #34495e !important;
}
.btn-primary a:hover {
background-color: #34495e !important;
border-color: #34495e !important;
}
}
</style>
</head>
<body class="" style="background-color: #f6f6f6; font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;">
<span class="preheader" style="color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0;">[%PreHeader%]</span>
<table border="0" cellpadding="0" cellspacing="0" class="body" style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background-color: #f6f6f6;">
<tr>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top;">&nbsp;</td>
<td class="container" style="font-family: sans-serif; font-size: 14px; vertical-align: top; display: block; Margin: 0 auto; max-width: 580px; padding: 10px; width: 580px;">
<div class="content" style="box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px;">

<!-- START CENTERED WHITE CONTAINER -->
<table class="main" style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background: #ffffff; border-radius: 3px;">

<!-- START MAIN CONTENT AREA -->
<tbody>
<tr>
<td class="wrapper" style="font-family: sans-serif; font-size: 14px; vertical-align: top; box-sizing: border-box; padding: 20px;">
<table style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;" border="0" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top;">
<p style="font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; margin-bottom: 15px;">New declaration form has just been submitted,</p>
<p style="font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; margin-bottom: 15px;">Declaration type:<br />[%DeclarationType%]</p>
</td>
</tr>
</tbody>
</table>
<table style="width: 710px;">
<tbody>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_badge%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Badgeid%]</td>
</tr>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_Name%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Name%]</td>
</tr>
  <tr>
<td style="width: 151.646px;padding:5px 10px;">Department</td>
<td style="width: 360.354px;padding:5px 10px;">[%Dept%]</td>
</tr>
[%Relationship%]
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_Destination%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Destination%]</td>
</tr>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_StartDate%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%StartDate%]</td>
</tr>
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_EndDate%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%EndDate%]</td>
</tr>
 [%TravelReason%]
<tr>
<td style="width: 151.646px;padding:5px 10px;">[%lbl_Remark%]</td>
<td style="width: 360.354px;padding:5px 10px;">[%Remark%]</td>
</tr>
</tbody>
</table>
   <br>

</td>
</tr>
<!-- END MAIN CONTENT AREA --></tbody>
</table>

<!-- START FOOTER -->
<div class="footer" style="clear: both; margin-top: 10px; text-align: center; width: 100%;">
<table style="border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;" border="0" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<td class="content-block powered-by" style="font-family: sans-serif; vertical-align: top; padding-bottom: 10px; padding-top: 10px; font-size: 12px; color: #999999; text-align: center;">COVID-19 Declaration System</td>
</tr>
</tbody>
</table>
</div>
<!-- END FOOTER --> <!-- END CENTERED WHITE CONTAINER -->
</div>
</td>
<td style="font-family: sans-serif; font-size: 14px; vertical-align: top;">&nbsp;</td>
</tr>
</table>
</body>
</html>')
GO
SET IDENTITY_INSERT [Covid_Declaration].[EmailTemplates] OFF
GO
INSERT [Covid_Declaration].[Employees] ([BadgeId], [Name], [Email], [Department], [SuperiorName], [SuperiorMail], [ApproverName], [ApproverMail], [SubmittedDate]) VALUES (N'12345', N'Alvin', N'alvinmaulananrs@gmail.com', N'IT', N'Alvin', N'alvin@gmail.com', N'Alvin', N'Alvin@gmail.com', CAST(N'2022-01-20T13:26:52.493' AS DateTime))
GO
SET IDENTITY_INSERT [Covid_Declaration].[Users] ON 
GO
INSERT [Covid_Declaration].[Users] ([Id], [Name], [UserName]) VALUES (1, N'Alvin', N'DESKTOP-5HSVVRI\Alvin Maulana')
GO
GO
INSERT [Covid_Declaration].[Users] ([Id], [Name], [UserName]) VALUES (1, N'You', N'Insert your windows account here')
GO
SET IDENTITY_INSERT [Covid_Declaration].[Users] OFF
GO
