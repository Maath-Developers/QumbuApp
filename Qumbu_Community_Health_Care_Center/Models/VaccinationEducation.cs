using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;

namespace Qumbu_Community_Health_Care_Center.Models
{
	public class VaccinationEducation
	{
		[Key]
		public int EducationID { get; set; }

		[DisplayName("Pfizer-BioNTech")]
		public string? Vaccine1 { get; set; }

		[DisplayName("Johnson & Johnson")]
		public string? Vaccine2 { get; set; }

		[DisplayName("Varicella Vaccine (Varivax)")]
		public string? Vaccine3 { get; set; }

		[DisplayName("Combination Vaccine (ProQuad or MMRV)")]
		public string? Vaccine4 { get; set; }

		[DisplayName("COMIRNATY (COVID-19 Vaccine, mRNA) is an FDA-approved COVID-19 vaccine made by Pfizer for BioNTech that is indicated for active immunization to prevent COVID-19 in individuals 12 years of age and older.")]
		public string? Description1 { get; set; }

		[DisplayName("The Janssen COVID-19 vaccine is authorized for use under an Emergency Use Authorization (EUA) for active immunization to prevent coronavirus disease 2019 (COVID-19) caused by severe acute respiratory syndrome coronavirus 2 (SARS-CoV-2) in individuals 18 years of age and older.")]
		public string? Description2 { get; set; }

		[DisplayName("The Varicella Vaccine, Varivax, is a live attenuated virus vaccine. This means it contains a weakened form of the varicella-zoster virus, which is responsible for causing chickenpox. The vaccine is administered via injection, typically as a liquid under the skin. The virus in the vaccine is significantly weakened so that it can stimulate an immune response in the body without causing the full-blown disease. This immune response helps the body build immunity to the varicella-zoster virus.")]
		public string? Description3 { get; set; }

		[DisplayName("ProQuad and MMRV are combination vaccines that contain weakened or attenuated forms of multiple viruses. They are typically administered via injection, usually as a liquid under the skin. The vaccine is designed to stimulate an immune response against four different viruses simultaneously: measles, mumps, rubella, and varicella-zoster (chickenpox) viruses. The MMRV vaccine combines the components of the MMR vaccine with the varicella vaccine.")]
		public string? Description4 { get; set; }

		[DisplayName("To teach our cells to make a protein- or even just a piece of protein-that triggers an immune responce inside our bodies")]
		public string? Purpose1 { get; set; }

		[DisplayName("It uses DNA/Viral vector technology, in which a modified version of a different virus (the vector) delivers important instructions to your cells to help train your immune system to fight against the COVID-19 virus. You just need one dose of this vaccine.")]
		public string? Purpose2 { get; set; }

		[DisplayName("Preventing Chickenpox: The vaccine is highly effective at preventing chickenpox, which is a contagious viral infection characterized by a rash of itchy red spots. Chickenpox can be especially severe in certain populations, such as infants, pregnant women, and individuals with weakened immune systems.\r\n\r\nReducing Disease Severity: In cases where vaccinated individuals do contract chickenpox, the vaccine typically leads to milder and less severe symptoms, reducing the risk of complications and hospitalization.\r\n\r\nPreventing Complications: Chickenpox can lead to various complications, including bacterial skin infections, pneumonia, and, in rare cases, severe neurological complications. The vaccine is effective at reducing the risk of these complications.\r\n\r\nPreventing Shingles: In addition to preventing chickenpox, the varicella vaccine has been shown to reduce the risk of developing shingles (herpes zoster) later in life. Shingles is a painful rash caused by reactivation of the varicella-zoster virus, which remains dormant in the body after a chickenpox infection.")]
		public string? Purpose3 { get; set; }

		[DisplayName("Measles: Measles is a highly contagious viral infection characterized by fever, cough, runny nose, and a distinctive red rash. The MMRV vaccine component provides protection against measles, reducing the risk of contracting and spreading the disease.\r\n\r\nMumps: Mumps is another contagious viral infection that can cause symptoms like swollen salivary glands, fever, and headache. The MMRV vaccine component offers protection against mumps.\r\n\r\nRubella (German Measles): Rubella is a viral infection that can cause a mild rash and fever but can have severe consequences if contracted during pregnancy, leading to congenital rubella syndrome. The MMRV vaccine provides immunity against rubella.\r\n\r\nVaricella (Chickenpox): The varicella component of the vaccine aims to prevent chickenpox, as described in a previous response. It is effective at reducing the risk of chickenpox and its complications.")]
		public string? Purpose4 { get; set; }

	}
}
