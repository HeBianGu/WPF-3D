using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericImageInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate data values from images using vtkGenericDataArray API
	///
	/// vtkGenericImageInterpolator provides a simple interface for interpolating image
	/// data.  It provides linear, cubic, and nearest-neighbor interpolation. The only
	/// difference between it and vtkImageInterpolator is vtkGenericImageInterpolator
	/// does not assume an underlying data structure for its data arrays; instead, it
	/// uses the API from vtkGenericDataArray to perform calculations.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageInterpolator vtkImageReslice
	/// </seealso>
	// Token: 0x0200084B RID: 2123
	public class vtkGenericImageInterpolator : vtkImageInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016061 RID: 90209 RVA: 0x001F02F8 File Offset: 0x001EE4F8
		static vtkGenericImageInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericImageInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericImageInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016062 RID: 90210 RVA: 0x001F0320 File Offset: 0x001EE520
		public vtkGenericImageInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016063 RID: 90211
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericImageInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016064 RID: 90212 RVA: 0x001F0330 File Offset: 0x001EE530
		public new static vtkGenericImageInterpolator New()
		{
			vtkGenericImageInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericImageInterpolator.vtkGenericImageInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016065 RID: 90213 RVA: 0x001F0384 File Offset: 0x001EE584
		public vtkGenericImageInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericImageInterpolator.vtkGenericImageInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016066 RID: 90214 RVA: 0x001F03C8 File Offset: 0x001EE5C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016067 RID: 90215
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericImageInterpolator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016068 RID: 90216 RVA: 0x001F03D4 File Offset: 0x001EE5D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericImageInterpolator.vtkGenericImageInterpolator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016069 RID: 90217
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericImageInterpolator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601606A RID: 90218 RVA: 0x001F03F4 File Offset: 0x001EE5F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericImageInterpolator.vtkGenericImageInterpolator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601606B RID: 90219
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericImageInterpolator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601606C RID: 90220 RVA: 0x001F0410 File Offset: 0x001EE610
		public override int IsA(string type)
		{
			return vtkGenericImageInterpolator.vtkGenericImageInterpolator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601606D RID: 90221
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericImageInterpolator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601606E RID: 90222 RVA: 0x001F0430 File Offset: 0x001EE630
		public new static int IsTypeOf(string type)
		{
			return vtkGenericImageInterpolator.vtkGenericImageInterpolator_IsTypeOf_04(type);
		}

		// Token: 0x0601606F RID: 90223
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericImageInterpolator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016070 RID: 90224 RVA: 0x001F044C File Offset: 0x001EE64C
		public new vtkGenericImageInterpolator NewInstance()
		{
			vtkGenericImageInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericImageInterpolator.vtkGenericImageInterpolator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016071 RID: 90225
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericImageInterpolator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016072 RID: 90226 RVA: 0x001F04A8 File Offset: 0x001EE6A8
		public new static vtkGenericImageInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkGenericImageInterpolator vtkGenericImageInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericImageInterpolator.vtkGenericImageInterpolator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericImageInterpolator = (vtkGenericImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericImageInterpolator.Register(null);
				}
			}
			return vtkGenericImageInterpolator;
		}

		// Token: 0x06016073 RID: 90227
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericImageInterpolator_Update_08(HandleRef pThis);

		/// <summary>
		/// Update the interpolator.  If the interpolator has been modified by
		/// a Set method since Initialize() was called, you must call this method
		/// to update the interpolator before you can use it.
		/// </summary>
		// Token: 0x06016074 RID: 90228 RVA: 0x001F0527 File Offset: 0x001EE727
		public override void Update()
		{
			vtkGenericImageInterpolator.vtkGenericImageInterpolator_Update_08(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018EA RID: 6378
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericImageInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018EB RID: 6379
		public new static readonly string MRClassNameKey = "class vtkGenericImageInterpolator";
	}
}
