#pragma once

namespace DialogueCreator {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::OpenFileDialog^  OFD;
	private: System::Windows::Forms::SaveFileDialog^  SFD;
	protected:

	protected:

	private: System::Windows::Forms::Button^  btnCreate;
	private: System::Windows::Forms::Button^  btnEdit;

	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->OFD = (gcnew System::Windows::Forms::OpenFileDialog());
			this->SFD = (gcnew System::Windows::Forms::SaveFileDialog());
			this->btnCreate = (gcnew System::Windows::Forms::Button());
			this->btnEdit = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// SFD
			// 
			this->SFD->DefaultExt = L"xml";
			// 
			// btnCreate
			// 
			this->btnCreate->Location = System::Drawing::Point(12, 12);
			this->btnCreate->Name = L"btnCreate";
			this->btnCreate->Size = System::Drawing::Size(75, 23);
			this->btnCreate->TabIndex = 0;
			this->btnCreate->Text = L"CREATE";
			this->btnCreate->UseVisualStyleBackColor = true;
			this->btnCreate->Click += gcnew System::EventHandler(this, &MyForm::btnCreate_Click);
			// 
			// btnEdit
			// 
			this->btnEdit->Location = System::Drawing::Point(12, 41);
			this->btnEdit->Name = L"btnEdit";
			this->btnEdit->Size = System::Drawing::Size(75, 23);
			this->btnEdit->TabIndex = 1;
			this->btnEdit->Text = L"EDIT";
			this->btnEdit->UseVisualStyleBackColor = true;
			this->btnEdit->Click += gcnew System::EventHandler(this, &MyForm::btnEdit_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(820, 261);
			this->Controls->Add(this->btnEdit);
			this->Controls->Add(this->btnCreate);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void btnCreate_Click(System::Object^  sender, System::EventArgs^  e) {
		SFD->ShowDialog();
	}
	private: System::Void btnEdit_Click(System::Object^  sender, System::EventArgs^  e) {
		OFD->ShowDialog();
	}
	};
}
