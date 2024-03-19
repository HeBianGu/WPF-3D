using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000015 RID: 21
	public class vtkDICOMVR : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600033E RID: 830 RVA: 0x0000BD2E File Offset: 0x00009F2E
		static vtkDICOMVR()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMVR.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMVR"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600033F RID: 831 RVA: 0x0000BD56 File Offset: 0x00009F56
		public vtkDICOMVR(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000340 RID: 832 RVA: 0x0000BD64 File Offset: 0x00009F64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000341 RID: 833
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMVR_GetText_01(HandleRef pThis);

		// Token: 0x06000342 RID: 834 RVA: 0x0000BD70 File Offset: 0x00009F70
		public string GetText()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMVR.vtkDICOMVR_GetText_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000343 RID: 835
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMVR_GetType_02(HandleRef pThis);

		// Token: 0x06000344 RID: 836 RVA: 0x0000BDAC File Offset: 0x00009FAC
		public int GetTypeWrapper()
		{
			return vtkDICOMVR.vtkDICOMVR_GetType_02(base.GetCppThis());
		}

		// Token: 0x06000345 RID: 837
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMVR_HasLongVL_03(HandleRef pThis);

		// Token: 0x06000346 RID: 838 RVA: 0x0000BDCC File Offset: 0x00009FCC
		public bool HasLongVL()
		{
			return vtkDICOMVR.vtkDICOMVR_HasLongVL_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06000347 RID: 839
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMVR_HasNumericValue_04(HandleRef pThis);

		// Token: 0x06000348 RID: 840 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		public bool HasNumericValue()
		{
			return vtkDICOMVR.vtkDICOMVR_HasNumericValue_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06000349 RID: 841
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMVR_HasSingleValue_05(HandleRef pThis);

		// Token: 0x0600034A RID: 842 RVA: 0x0000BE1C File Offset: 0x0000A01C
		public bool HasSingleValue()
		{
			return vtkDICOMVR.vtkDICOMVR_HasSingleValue_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0600034B RID: 843
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMVR_HasSpecificCharacterSet_06(HandleRef pThis);

		// Token: 0x0600034C RID: 844 RVA: 0x0000BE44 File Offset: 0x0000A044
		public bool HasSpecificCharacterSet()
		{
			return vtkDICOMVR.vtkDICOMVR_HasSpecificCharacterSet_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600034D RID: 845
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMVR_HasTextValue_07(HandleRef pThis);

		// Token: 0x0600034E RID: 846 RVA: 0x0000BE6C File Offset: 0x0000A06C
		public bool HasTextValue()
		{
			return vtkDICOMVR.vtkDICOMVR_HasTextValue_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600034F RID: 847
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMVR_IsValid_08(HandleRef pThis);

		// Token: 0x06000350 RID: 848 RVA: 0x0000BE94 File Offset: 0x0000A094
		public bool IsValid()
		{
			return vtkDICOMVR.vtkDICOMVR_IsValid_08(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000144 RID: 324
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMVR";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000145 RID: 325
		public new static readonly string MRClassNameKey = "class vtkDICOMVR";

		// Token: 0x02000016 RID: 22
		public enum EnumType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000147 RID: 327
			AE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000148 RID: 328
			AS,
			/// <summary>enum member</summary>
			// Token: 0x04000149 RID: 329
			AT,
			/// <summary>enum member</summary>
			// Token: 0x0400014A RID: 330
			CS,
			/// <summary>enum member</summary>
			// Token: 0x0400014B RID: 331
			DA,
			/// <summary>enum member</summary>
			// Token: 0x0400014C RID: 332
			DS,
			/// <summary>enum member</summary>
			// Token: 0x0400014D RID: 333
			DT,
			/// <summary>enum member</summary>
			// Token: 0x0400014E RID: 334
			FD,
			/// <summary>enum member</summary>
			// Token: 0x0400014F RID: 335
			FL,
			/// <summary>enum member</summary>
			// Token: 0x04000150 RID: 336
			IS,
			/// <summary>enum member</summary>
			// Token: 0x04000151 RID: 337
			LO,
			/// <summary>enum member</summary>
			// Token: 0x04000152 RID: 338
			LT,
			/// <summary>enum member</summary>
			// Token: 0x04000153 RID: 339
			OB,
			/// <summary>enum member</summary>
			// Token: 0x04000154 RID: 340
			OD,
			/// <summary>enum member</summary>
			// Token: 0x04000155 RID: 341
			OF,
			/// <summary>enum member</summary>
			// Token: 0x04000156 RID: 342
			OL,
			/// <summary>enum member</summary>
			// Token: 0x04000157 RID: 343
			OV = 34,
			/// <summary>enum member</summary>
			// Token: 0x04000158 RID: 344
			OW = 17,
			/// <summary>enum member</summary>
			// Token: 0x04000159 RID: 345
			OX = 32,
			/// <summary>enum member</summary>
			// Token: 0x0400015A RID: 346
			PN = 18,
			/// <summary>enum member</summary>
			// Token: 0x0400015B RID: 347
			SH,
			/// <summary>enum member</summary>
			// Token: 0x0400015C RID: 348
			SL,
			/// <summary>enum member</summary>
			// Token: 0x0400015D RID: 349
			SQ,
			/// <summary>enum member</summary>
			// Token: 0x0400015E RID: 350
			SS,
			/// <summary>enum member</summary>
			// Token: 0x0400015F RID: 351
			ST,
			/// <summary>enum member</summary>
			// Token: 0x04000160 RID: 352
			SV = 35,
			/// <summary>enum member</summary>
			// Token: 0x04000161 RID: 353
			TM = 24,
			/// <summary>enum member</summary>
			// Token: 0x04000162 RID: 354
			UC,
			/// <summary>enum member</summary>
			// Token: 0x04000163 RID: 355
			UI,
			/// <summary>enum member</summary>
			// Token: 0x04000164 RID: 356
			UL,
			/// <summary>enum member</summary>
			// Token: 0x04000165 RID: 357
			UN,
			/// <summary>enum member</summary>
			// Token: 0x04000166 RID: 358
			UR,
			/// <summary>enum member</summary>
			// Token: 0x04000167 RID: 359
			US,
			/// <summary>enum member</summary>
			// Token: 0x04000168 RID: 360
			UT,
			/// <summary>enum member</summary>
			// Token: 0x04000169 RID: 361
			UV = 36,
			/// <summary>enum member</summary>
			// Token: 0x0400016A RID: 362
			XS = 33,
			/// <summary>enum member</summary>
			// Token: 0x0400016B RID: 363
			XX = 0
		}
	}
}
