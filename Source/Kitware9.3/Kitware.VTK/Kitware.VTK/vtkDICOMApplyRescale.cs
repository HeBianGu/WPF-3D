using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkDICOMApplyRescale
	/// \brief Convert pixels to real-world values.
	///
	/// This filter uses the information in the DICOM meta data to convert the
	/// pixel values to real-world values with known units.  It uses the DICOM
	/// RealWorldValueMapping attributes, if present, otherwise it uses the
	/// RescaleSlope and RescaleIntercept.  If no mapping information is present,
	/// then the pixels are simply converted to floating-point.
	///
	/// \warning If this filter is used, then AutoRescaleOff() should be set on
	/// the reader to ensure that the reader does not rescale the data.
	/// </summary>
	// Token: 0x02000041 RID: 65
	public class vtkDICOMApplyRescale : vtkDICOMAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000BBE RID: 3006 RVA: 0x00017B27 File Offset: 0x00015D27
		static vtkDICOMApplyRescale()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMApplyRescale.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMApplyRescale"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000BBF RID: 3007 RVA: 0x00017B4F File Offset: 0x00015D4F
		public vtkDICOMApplyRescale(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000BC0 RID: 3008
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMApplyRescale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BC1 RID: 3009 RVA: 0x00017B60 File Offset: 0x00015D60
		public new static vtkDICOMApplyRescale New()
		{
			vtkDICOMApplyRescale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMApplyRescale.vtkDICOMApplyRescale_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMApplyRescale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BC2 RID: 3010 RVA: 0x00017BB4 File Offset: 0x00015DB4
		public vtkDICOMApplyRescale() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMApplyRescale.vtkDICOMApplyRescale_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000BC3 RID: 3011 RVA: 0x00017BF8 File Offset: 0x00015DF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000BC4 RID: 3012
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMApplyRescale_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BC5 RID: 3013 RVA: 0x00017C04 File Offset: 0x00015E04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMApplyRescale.vtkDICOMApplyRescale_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06000BC6 RID: 3014
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMApplyRescale_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BC7 RID: 3015 RVA: 0x00017C24 File Offset: 0x00015E24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMApplyRescale.vtkDICOMApplyRescale_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06000BC8 RID: 3016
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMApplyRescale_GetOutputScalarType_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BC9 RID: 3017 RVA: 0x00017C40 File Offset: 0x00015E40
		public int GetOutputScalarType()
		{
			return vtkDICOMApplyRescale.vtkDICOMApplyRescale_GetOutputScalarType_03(base.GetCppThis());
		}

		// Token: 0x06000BCA RID: 3018
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMApplyRescale_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BCB RID: 3019 RVA: 0x00017C60 File Offset: 0x00015E60
		public override int IsA(string type)
		{
			return vtkDICOMApplyRescale.vtkDICOMApplyRescale_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06000BCC RID: 3020
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMApplyRescale_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BCD RID: 3021 RVA: 0x00017C80 File Offset: 0x00015E80
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMApplyRescale.vtkDICOMApplyRescale_IsTypeOf_05(type);
		}

		// Token: 0x06000BCE RID: 3022
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMApplyRescale_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BCF RID: 3023 RVA: 0x00017C9C File Offset: 0x00015E9C
		public new vtkDICOMApplyRescale NewInstance()
		{
			vtkDICOMApplyRescale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMApplyRescale.vtkDICOMApplyRescale_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMApplyRescale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000BD0 RID: 3024
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMApplyRescale_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BD1 RID: 3025 RVA: 0x00017CF8 File Offset: 0x00015EF8
		public new static vtkDICOMApplyRescale SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMApplyRescale vtkDICOMApplyRescale = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMApplyRescale.vtkDICOMApplyRescale_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMApplyRescale = (vtkDICOMApplyRescale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMApplyRescale.Register(null);
				}
			}
			return vtkDICOMApplyRescale;
		}

		// Token: 0x06000BD2 RID: 3026
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMApplyRescale_SetOutputScalarType_09(HandleRef pThis, int t);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BD3 RID: 3027 RVA: 0x00017D77 File Offset: 0x00015F77
		public void SetOutputScalarType(int t)
		{
			vtkDICOMApplyRescale.vtkDICOMApplyRescale_SetOutputScalarType_09(base.GetCppThis(), t);
		}

		// Token: 0x06000BD4 RID: 3028
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMApplyRescale_SetOutputScalarTypeToDouble_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BD5 RID: 3029 RVA: 0x00017D87 File Offset: 0x00015F87
		public void SetOutputScalarTypeToDouble()
		{
			vtkDICOMApplyRescale.vtkDICOMApplyRescale_SetOutputScalarTypeToDouble_10(base.GetCppThis());
		}

		// Token: 0x06000BD6 RID: 3030
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMApplyRescale_SetOutputScalarTypeToFloat_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BD7 RID: 3031 RVA: 0x00017D96 File Offset: 0x00015F96
		public void SetOutputScalarTypeToFloat()
		{
			vtkDICOMApplyRescale.vtkDICOMApplyRescale_SetOutputScalarTypeToFloat_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003B3 RID: 947
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMApplyRescale";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003B4 RID: 948
		public new static readonly string MRClassNameKey = "class vtkDICOMApplyRescale";
	}
}
