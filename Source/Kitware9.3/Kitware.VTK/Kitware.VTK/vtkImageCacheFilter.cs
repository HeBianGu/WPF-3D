using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageCacheFilter
	/// </summary>
	/// <remarks>
	///    Caches multiple vtkImageData objects.
	///
	///
	/// vtkImageCacheFilter keep a number of vtkImageDataObjects from previous
	/// updates to satisfy future updates without needing to update the input.  It
	/// does not change the data at all.  It just makes the pipeline more
	/// efficient at the expense of using extra memory.
	/// </remarks>
	// Token: 0x02000851 RID: 2129
	public class vtkImageCacheFilter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016146 RID: 90438 RVA: 0x001F1797 File Offset: 0x001EF997
		static vtkImageCacheFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCacheFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCacheFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016147 RID: 90439 RVA: 0x001F17BF File Offset: 0x001EF9BF
		public vtkImageCacheFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016148 RID: 90440
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCacheFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016149 RID: 90441 RVA: 0x001F17D0 File Offset: 0x001EF9D0
		public new static vtkImageCacheFilter New()
		{
			vtkImageCacheFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCacheFilter.vtkImageCacheFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCacheFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601614A RID: 90442 RVA: 0x001F1824 File Offset: 0x001EFA24
		public vtkImageCacheFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageCacheFilter.vtkImageCacheFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601614B RID: 90443 RVA: 0x001F1868 File Offset: 0x001EFA68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601614C RID: 90444
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCacheFilter_GetCacheSize_01(HandleRef pThis);

		/// <summary>
		/// This is the maximum number of images that can be retained in memory.
		/// it defaults to 10.
		/// </summary>
		// Token: 0x0601614D RID: 90445 RVA: 0x001F1874 File Offset: 0x001EFA74
		public int GetCacheSize()
		{
			return vtkImageCacheFilter.vtkImageCacheFilter_GetCacheSize_01(base.GetCppThis());
		}

		// Token: 0x0601614E RID: 90446
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCacheFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601614F RID: 90447 RVA: 0x001F1894 File Offset: 0x001EFA94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageCacheFilter.vtkImageCacheFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06016150 RID: 90448
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCacheFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016151 RID: 90449 RVA: 0x001F18B4 File Offset: 0x001EFAB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageCacheFilter.vtkImageCacheFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06016152 RID: 90450
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCacheFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016153 RID: 90451 RVA: 0x001F18D0 File Offset: 0x001EFAD0
		public override int IsA(string type)
		{
			return vtkImageCacheFilter.vtkImageCacheFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016154 RID: 90452
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCacheFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016155 RID: 90453 RVA: 0x001F18F0 File Offset: 0x001EFAF0
		public new static int IsTypeOf(string type)
		{
			return vtkImageCacheFilter.vtkImageCacheFilter_IsTypeOf_05(type);
		}

		// Token: 0x06016156 RID: 90454
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCacheFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016157 RID: 90455 RVA: 0x001F190C File Offset: 0x001EFB0C
		public new vtkImageCacheFilter NewInstance()
		{
			vtkImageCacheFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCacheFilter.vtkImageCacheFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCacheFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016158 RID: 90456
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCacheFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016159 RID: 90457 RVA: 0x001F1968 File Offset: 0x001EFB68
		public new static vtkImageCacheFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageCacheFilter vtkImageCacheFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCacheFilter.vtkImageCacheFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCacheFilter = (vtkImageCacheFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCacheFilter.Register(null);
				}
			}
			return vtkImageCacheFilter;
		}

		// Token: 0x0601615A RID: 90458
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCacheFilter_SetCacheSize_09(HandleRef pThis, int size);

		/// <summary>
		/// This is the maximum number of images that can be retained in memory.
		/// it defaults to 10.
		/// </summary>
		// Token: 0x0601615B RID: 90459 RVA: 0x001F19E7 File Offset: 0x001EFBE7
		public void SetCacheSize(int size)
		{
			vtkImageCacheFilter.vtkImageCacheFilter_SetCacheSize_09(base.GetCppThis(), size);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F6 RID: 6390
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCacheFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F7 RID: 6391
		public new static readonly string MRClassNameKey = "class vtkImageCacheFilter";
	}
}
