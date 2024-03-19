using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMINCImageWriter
	/// </summary>
	/// <remarks>
	///    A writer for MINC files.
	///
	/// MINC is a NetCDF-based medical image file format that was developed
	/// at the Montreal Neurological Institute in 1992.
	/// The data is written slice-by-slice, and this writer is therefore
	/// suitable for streaming MINC data that is larger than the memory
	/// size through VTK.  This writer can also produce files with up to
	/// 4 dimensions, where the fourth dimension is provided by using
	/// AddInput() to specify multiple input data sets.  If you want to
	/// set header information for the file, you must supply a
	/// vtkMINCImageAttributes
	/// </remarks>
	/// <seealso>
	///
	/// vtkMINCImageReader vtkMINCImageAttributes
	/// @par Thanks:
	/// Thanks to David Gobbi for writing this class and Atamai Inc. for
	/// contributing it to VTK.
	/// </seealso>
	// Token: 0x0200017A RID: 378
	public class vtkMINCImageWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004820 RID: 18464 RVA: 0x00068F1F File Offset: 0x0006711F
		static vtkMINCImageWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMINCImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMINCImageWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004821 RID: 18465 RVA: 0x00068F47 File Offset: 0x00067147
		public vtkMINCImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004822 RID: 18466
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004823 RID: 18467 RVA: 0x00068F58 File Offset: 0x00067158
		public new static vtkMINCImageWriter New()
		{
			vtkMINCImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004824 RID: 18468 RVA: 0x00068FAC File Offset: 0x000671AC
		public vtkMINCImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMINCImageWriter.vtkMINCImageWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004825 RID: 18469 RVA: 0x00068FF0 File Offset: 0x000671F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004826 RID: 18470
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageWriter_GetDescriptiveName_01(HandleRef pThis);

		/// <summary>
		/// Get the name of this file format.
		/// </summary>
		// Token: 0x06004827 RID: 18471 RVA: 0x00068FFC File Offset: 0x000671FC
		public virtual string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMINCImageWriter.vtkMINCImageWriter_GetDescriptiveName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004828 RID: 18472
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageWriter_GetDirectionCosines_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a matrix that describes the orientation of the data.  The
		/// three columns of this matrix should give the unit-vector
		/// directions for the VTK x, y and z dimensions respectively.
		/// The writer will use this information to determine how to map
		/// the VTK dimensions to the canonical MINC dimensions, and if
		/// necessary, the writer will re-order one or more dimensions
		/// back-to-front to ensure that no MINC dimension ends up with
		/// a direction cosines vector whose dot product with the canonical
		/// unit vector for that dimension is negative.
		/// </summary>
		// Token: 0x06004829 RID: 18473 RVA: 0x00069038 File Offset: 0x00067238
		public virtual vtkMatrix4x4 GetDirectionCosines()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_GetDirectionCosines_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0600482A RID: 18474
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageWriter_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// Get the extension for this file format.
		/// </summary>
		// Token: 0x0600482B RID: 18475 RVA: 0x000690A8 File Offset: 0x000672A8
		public virtual string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkMINCImageWriter.vtkMINCImageWriter_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600482C RID: 18476
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageWriter_GetHistoryAddition_04(HandleRef pThis);

		/// <summary>
		/// Set a string value to append to the history of the file.  This
		/// string should describe, briefly, how the file was processed.
		/// </summary>
		// Token: 0x0600482D RID: 18477 RVA: 0x000690E4 File Offset: 0x000672E4
		public virtual string GetHistoryAddition()
		{
			string s = Marshal.PtrToStringAnsi(vtkMINCImageWriter.vtkMINCImageWriter_GetHistoryAddition_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600482E RID: 18478
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageWriter_GetImageAttributes_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the image attributes, which contain patient information and
		/// other useful metadata.
		/// </summary>
		// Token: 0x0600482F RID: 18479 RVA: 0x00069120 File Offset: 0x00067320
		public virtual vtkMINCImageAttributes GetImageAttributes()
		{
			vtkMINCImageAttributes vtkMINCImageAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_GetImageAttributes_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageAttributes = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageAttributes.Register(null);
				}
			}
			return vtkMINCImageAttributes;
		}

		// Token: 0x06004830 RID: 18480
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMINCImageWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004831 RID: 18481 RVA: 0x00069190 File Offset: 0x00067390
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06004832 RID: 18482
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMINCImageWriter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004833 RID: 18483 RVA: 0x000691B0 File Offset: 0x000673B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06004834 RID: 18484
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMINCImageWriter_GetRescaleIntercept_08(HandleRef pThis);

		/// <summary>
		/// Set the slope and intercept for rescaling the intensities.  The
		/// default values are zero, which indicates to the reader that no
		/// rescaling is to be performed.
		/// </summary>
		// Token: 0x06004835 RID: 18485 RVA: 0x000691CC File Offset: 0x000673CC
		public virtual double GetRescaleIntercept()
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_GetRescaleIntercept_08(base.GetCppThis());
		}

		// Token: 0x06004836 RID: 18486
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMINCImageWriter_GetRescaleSlope_09(HandleRef pThis);

		/// <summary>
		/// Set the slope and intercept for rescaling the intensities.  The
		/// default values are zero, which indicates to the reader that no
		/// rescaling is to be performed.
		/// </summary>
		// Token: 0x06004837 RID: 18487 RVA: 0x000691EC File Offset: 0x000673EC
		public virtual double GetRescaleSlope()
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_GetRescaleSlope_09(base.GetCppThis());
		}

		// Token: 0x06004838 RID: 18488
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageWriter_GetStrictValidation_10(HandleRef pThis);

		/// <summary>
		/// Set whether to validate that all variable attributes that
		/// have been set are ones that are listed in the MINC standard.
		/// </summary>
		// Token: 0x06004839 RID: 18489 RVA: 0x0006920C File Offset: 0x0006740C
		public virtual int GetStrictValidation()
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_GetStrictValidation_10(base.GetCppThis());
		}

		// Token: 0x0600483A RID: 18490
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageWriter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600483B RID: 18491 RVA: 0x0006922C File Offset: 0x0006742C
		public override int IsA(string type)
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600483C RID: 18492
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageWriter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600483D RID: 18493 RVA: 0x0006924C File Offset: 0x0006744C
		public new static int IsTypeOf(string type)
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_IsTypeOf_12(type);
		}

		// Token: 0x0600483E RID: 18494
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageWriter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600483F RID: 18495 RVA: 0x00069268 File Offset: 0x00067468
		public new vtkMINCImageWriter NewInstance()
		{
			vtkMINCImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004840 RID: 18496
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004841 RID: 18497 RVA: 0x000692C4 File Offset: 0x000674C4
		public new static vtkMINCImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMINCImageWriter vtkMINCImageWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageWriter = (vtkMINCImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageWriter.Register(null);
				}
			}
			return vtkMINCImageWriter;
		}

		// Token: 0x06004842 RID: 18498
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_SetDirectionCosines_16(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Set a matrix that describes the orientation of the data.  The
		/// three columns of this matrix should give the unit-vector
		/// directions for the VTK x, y and z dimensions respectively.
		/// The writer will use this information to determine how to map
		/// the VTK dimensions to the canonical MINC dimensions, and if
		/// necessary, the writer will re-order one or more dimensions
		/// back-to-front to ensure that no MINC dimension ends up with
		/// a direction cosines vector whose dot product with the canonical
		/// unit vector for that dimension is negative.
		/// </summary>
		// Token: 0x06004843 RID: 18499 RVA: 0x00069344 File Offset: 0x00067544
		public virtual void SetDirectionCosines(vtkMatrix4x4 matrix)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetDirectionCosines_16(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06004844 RID: 18500
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_SetFileName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x06004845 RID: 18501 RVA: 0x00069373 File Offset: 0x00067573
		public override void SetFileName(string name)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetFileName_17(base.GetCppThis(), name);
		}

		// Token: 0x06004846 RID: 18502
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_SetHistoryAddition_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set a string value to append to the history of the file.  This
		/// string should describe, briefly, how the file was processed.
		/// </summary>
		// Token: 0x06004847 RID: 18503 RVA: 0x00069383 File Offset: 0x00067583
		public virtual void SetHistoryAddition(string _arg)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetHistoryAddition_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06004848 RID: 18504
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_SetImageAttributes_19(HandleRef pThis, HandleRef attributes);

		/// <summary>
		/// Set the image attributes, which contain patient information and
		/// other useful metadata.
		/// </summary>
		// Token: 0x06004849 RID: 18505 RVA: 0x00069394 File Offset: 0x00067594
		public virtual void SetImageAttributes(vtkMINCImageAttributes attributes)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetImageAttributes_19(base.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis());
		}

		// Token: 0x0600484A RID: 18506
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_SetRescaleIntercept_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the slope and intercept for rescaling the intensities.  The
		/// default values are zero, which indicates to the reader that no
		/// rescaling is to be performed.
		/// </summary>
		// Token: 0x0600484B RID: 18507 RVA: 0x000693C3 File Offset: 0x000675C3
		public virtual void SetRescaleIntercept(double _arg)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetRescaleIntercept_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600484C RID: 18508
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_SetRescaleSlope_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the slope and intercept for rescaling the intensities.  The
		/// default values are zero, which indicates to the reader that no
		/// rescaling is to be performed.
		/// </summary>
		// Token: 0x0600484D RID: 18509 RVA: 0x000693D3 File Offset: 0x000675D3
		public virtual void SetRescaleSlope(double _arg)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetRescaleSlope_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600484E RID: 18510
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_SetStrictValidation_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to validate that all variable attributes that
		/// have been set are ones that are listed in the MINC standard.
		/// </summary>
		// Token: 0x0600484F RID: 18511 RVA: 0x000693E3 File Offset: 0x000675E3
		public virtual void SetStrictValidation(int _arg)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetStrictValidation_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06004850 RID: 18512
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_StrictValidationOff_23(HandleRef pThis);

		/// <summary>
		/// Set whether to validate that all variable attributes that
		/// have been set are ones that are listed in the MINC standard.
		/// </summary>
		// Token: 0x06004851 RID: 18513 RVA: 0x000693F3 File Offset: 0x000675F3
		public virtual void StrictValidationOff()
		{
			vtkMINCImageWriter.vtkMINCImageWriter_StrictValidationOff_23(base.GetCppThis());
		}

		// Token: 0x06004852 RID: 18514
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_StrictValidationOn_24(HandleRef pThis);

		/// <summary>
		/// Set whether to validate that all variable attributes that
		/// have been set are ones that are listed in the MINC standard.
		/// </summary>
		// Token: 0x06004853 RID: 18515 RVA: 0x00069402 File Offset: 0x00067602
		public virtual void StrictValidationOn()
		{
			vtkMINCImageWriter.vtkMINCImageWriter_StrictValidationOn_24(base.GetCppThis());
		}

		// Token: 0x06004854 RID: 18516
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageWriter_Write_25(HandleRef pThis);

		/// <summary>
		/// Write the data.  This will attempt to stream the data
		/// slice-by-slice through the pipeline and out to the file,
		/// unless the whole extent of the input has already been
		/// updated.
		/// </summary>
		// Token: 0x06004855 RID: 18517 RVA: 0x00069411 File Offset: 0x00067611
		public override void Write()
		{
			vtkMINCImageWriter.vtkMINCImageWriter_Write_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000745 RID: 1861
		public new const string MRFullTypeName = "Kitware.VTK.vtkMINCImageWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000746 RID: 1862
		public new static readonly string MRClassNameKey = "class vtkMINCImageWriter";
	}
}
