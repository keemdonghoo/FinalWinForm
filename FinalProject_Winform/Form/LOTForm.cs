﻿using BarcodeStandard;
using Microsoft.IdentityModel.Tokens;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Winform
{
    public partial class LOTForm : Form
    {
        public LOTForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) //지우면 날라감
        {

        }

        private void label3_Click(object sender, EventArgs e) //지우면 날라감
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_item.Text == "제품선택" && textBox_count.!Text.IsNullOrEmpty()) {
                comboBox_item.Text = lbl_item.Text;
                textBox_count.Text = lbl_count.Text;
                MessageBox.Show("제품과 수량을 입력해주세요");
            }


            string barcodeText = lbl_barcode.Text.Trim();
            if (string.IsNullOrEmpty(barcodeText)) { return; }

            Barcode barcode = new();

            SKImage img = barcode.Encode(
                BarcodeStandard.Type.Ean13   // Barcode type
                , barcodeText                // 변환할 텍스트
                , new SKColor(0, 0, 0)       // fore color (바코드 색상) r,g,b
                , new SKColor(0, 0, 0, 0)   // back color (배경 색상)  r,g,b,a
                , (int)(picture_Barcode.Width * 0.8)   // width
                , (int)(picture_Barcode.Height * 0.8) // height
                );

            picture_Barcode.Image = Image.FromStream(img.Encode().AsStream());
        }
    }
}