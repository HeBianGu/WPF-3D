using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkDICOMApplyPalette
	/// \brief Apply palette to PALETTE COLOR images
	///
	/// If an image contains a palette LUT, then this filter will apply that
	/// LUT to the image and produce an RGB image.  Images without a palette
	/// LUT will pass through unchanged.  If the image uses a supplemental
	/// palette that only applies to a specific range of pixel values, then
	/// pixel values outside of that range will be mapped to greyscale via
	/// the WindowWidth and WindowCenter specified in the image.
	///
	/// \warning If this filter is used, then AutoRescaleOff() should be set on
	/// the reader to ensure that the reader does not rescale the data.
	/// </summary>
	// Token: 0x02000040 RID: 64
	public class vtkDICOMApplyPalette : vtkDICOMAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000BAC RID: 2988 RVA: 0x000178F7 File Offset: 0x00015AF7
		static vtkDICOMApplyPalette()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMApplyPalette.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMApplyPalette"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000BAD RID: 2989 RVA: 0x0001791F File Offset: 0x00015B1F
		public vtkDICOMApplyPalette(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000BAE RID: 2990
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMApplyPalette_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BAF RID: 2991 RVA: 0x00017930 File Offset: 0x00015B30
		public new static vtkDICOMApplyPalette New()
		{
			vtkDICOMApplyPalette result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMApplyPalette.vtkDICOMApplyPalette_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMApplyPalette)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BB0 RID: 2992 RVA: 0x00017984 File Offset: 0x00015B84
		public vtkDICOMApplyPalette() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMApplyPalette.vtkDICOMApplyPalette_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000BB1 RID: 2993 RVA: 0x000179C8 File Offset: 0x00015BC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000BB2 RID: 2994
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMApplyPalette_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BB3 RID: 2995 RVA: 0x000179D4 File Offset: 0x00015BD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMApplyPalette.vtkDICOMApplyPalette_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06000BB4 RID: 2996
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMApplyPalette_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BB5 RID: 2997 RVA: 0x000179F4 File Offset: 0x00015BF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMApplyPalette.vtkDICOMApplyPalette_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06000BB6 RID: 2998
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMApplyPalette_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BB7 RID: 2999 RVA: 0x00017A10 File Offset: 0x00015C10
		public override int IsA(string type)
		{
			return vtkDICOMApplyPalette.vtkDICOMApplyPalette_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06000BB8 RID: 3000
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMApplyPalette_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BB9 RID: 3001 RVA: 0x00017A30 File Offset: 0x00015C30
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMApplyPalette.vtkDICOMApplyPalette_IsTypeOf_04(type);
		}

		// Token: 0x06000BBA RID: 3002
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMApplyPalette_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BBB RID: 3003 RVA: 0x00017A4C File Offset: 0x00015C4C
		public new vtkDICOMApplyPalette NewInstance()
		{
			vtkDICOMApplyPalette result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMApplyPalette.vtkDICOMApplyPalette_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMApplyPalette)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000BBC RID: 3004
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMApplyPalette_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BBD RID: 3005 RVA: 0x00017AA8 File Offset: 0x00015CA8
		public new static vtkDICOMApplyPalette SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMApplyPalette vtkDICOMApplyPalette = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMApplyPalette.vtkDICOMApplyPalette_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMApplyPalette = (vtkDICOMApplyPalette)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMApplyPalette.Register(null);
				}
			}
			return vtkDICOMApplyPalette;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003B1 RID: 945
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMApplyPalette";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003B2 RID: 946
		public new static readonly string MRClassNameKey = "class vtkDICOMApplyPalette";
	}
}
