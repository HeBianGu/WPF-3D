using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDecomposeFilter
	/// </summary>
	/// <remarks>
	///    Filters that execute axes in series.
	///
	/// This superclass molds the vtkImageIterateFilter superclass so
	/// it iterates over the axes.  The filter uses dimensionality to
	/// determine how many axes to execute (starting from x).
	/// The filter also provides convenience methods for permuting information
	/// retrieved from input, output and vtkImageData.
	/// </remarks>
	// Token: 0x0200025C RID: 604
	public class vtkImageDecomposeFilter : vtkImageIterateFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006F9E RID: 28574 RVA: 0x000A0C01 File Offset: 0x0009EE01
		static vtkImageDecomposeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDecomposeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDecomposeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006F9F RID: 28575 RVA: 0x000A0C29 File Offset: 0x0009EE29
		public vtkImageDecomposeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006FA0 RID: 28576 RVA: 0x000A0C37 File Offset: 0x0009EE37
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006FA1 RID: 28577
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDecomposeFilter_GetDimensionality_01(HandleRef pThis);

		/// <summary>
		/// Dimensionality is the number of axes which are considered during
		/// execution. To process images dimensionality would be set to 2.
		/// </summary>
		// Token: 0x06006FA2 RID: 28578 RVA: 0x000A0C44 File Offset: 0x0009EE44
		public virtual int GetDimensionality()
		{
			return vtkImageDecomposeFilter.vtkImageDecomposeFilter_GetDimensionality_01(base.GetCppThis());
		}

		// Token: 0x06006FA3 RID: 28579
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDecomposeFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageDecomposeFilter filter with default
		/// dimensionality 3.
		/// </summary>
		// Token: 0x06006FA4 RID: 28580 RVA: 0x000A0C64 File Offset: 0x0009EE64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDecomposeFilter.vtkImageDecomposeFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006FA5 RID: 28581
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDecomposeFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageDecomposeFilter filter with default
		/// dimensionality 3.
		/// </summary>
		// Token: 0x06006FA6 RID: 28582 RVA: 0x000A0C84 File Offset: 0x0009EE84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDecomposeFilter.vtkImageDecomposeFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006FA7 RID: 28583
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDecomposeFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageDecomposeFilter filter with default
		/// dimensionality 3.
		/// </summary>
		// Token: 0x06006FA8 RID: 28584 RVA: 0x000A0CA0 File Offset: 0x0009EEA0
		public override int IsA(string type)
		{
			return vtkImageDecomposeFilter.vtkImageDecomposeFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06006FA9 RID: 28585
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDecomposeFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageDecomposeFilter filter with default
		/// dimensionality 3.
		/// </summary>
		// Token: 0x06006FAA RID: 28586 RVA: 0x000A0CC0 File Offset: 0x0009EEC0
		public new static int IsTypeOf(string type)
		{
			return vtkImageDecomposeFilter.vtkImageDecomposeFilter_IsTypeOf_05(type);
		}

		// Token: 0x06006FAB RID: 28587
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDecomposeFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageDecomposeFilter filter with default
		/// dimensionality 3.
		/// </summary>
		// Token: 0x06006FAC RID: 28588 RVA: 0x000A0CDC File Offset: 0x0009EEDC
		public new vtkImageDecomposeFilter NewInstance()
		{
			vtkImageDecomposeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDecomposeFilter.vtkImageDecomposeFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDecomposeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006FAD RID: 28589
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDecomposeFilter_PermuteExtent_07(HandleRef pThis, IntPtr extent, ref int min0, ref int max0, ref int min1, ref int max1, ref int min2, ref int max2);

		/// <summary>
		/// Private methods kept public for template execute functions.
		/// </summary>
		// Token: 0x06006FAE RID: 28590 RVA: 0x000A0D36 File Offset: 0x0009EF36
		public void PermuteExtent(IntPtr extent, ref int min0, ref int max0, ref int min1, ref int max1, ref int min2, ref int max2)
		{
			vtkImageDecomposeFilter.vtkImageDecomposeFilter_PermuteExtent_07(base.GetCppThis(), extent, ref min0, ref max0, ref min1, ref max1, ref min2, ref max2);
		}

		// Token: 0x06006FAF RID: 28591
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDecomposeFilter_PermuteIncrements_08(HandleRef pThis, IntPtr increments, ref long inc0, ref long inc1, ref long inc2);

		/// <summary>
		/// Private methods kept public for template execute functions.
		/// </summary>
		// Token: 0x06006FB0 RID: 28592 RVA: 0x000A0D50 File Offset: 0x0009EF50
		public void PermuteIncrements(IntPtr increments, ref long inc0, ref long inc1, ref long inc2)
		{
			vtkImageDecomposeFilter.vtkImageDecomposeFilter_PermuteIncrements_08(base.GetCppThis(), increments, ref inc0, ref inc1, ref inc2);
		}

		// Token: 0x06006FB1 RID: 28593
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDecomposeFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageDecomposeFilter filter with default
		/// dimensionality 3.
		/// </summary>
		// Token: 0x06006FB2 RID: 28594 RVA: 0x000A0D64 File Offset: 0x0009EF64
		public new static vtkImageDecomposeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageDecomposeFilter vtkImageDecomposeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDecomposeFilter.vtkImageDecomposeFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDecomposeFilter = (vtkImageDecomposeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDecomposeFilter.Register(null);
				}
			}
			return vtkImageDecomposeFilter;
		}

		// Token: 0x06006FB3 RID: 28595
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDecomposeFilter_SetDimensionality_10(HandleRef pThis, int dim);

		/// <summary>
		/// Dimensionality is the number of axes which are considered during
		/// execution. To process images dimensionality would be set to 2.
		/// </summary>
		// Token: 0x06006FB4 RID: 28596 RVA: 0x000A0DE3 File Offset: 0x0009EFE3
		public void SetDimensionality(int dim)
		{
			vtkImageDecomposeFilter.vtkImageDecomposeFilter_SetDimensionality_10(base.GetCppThis(), dim);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009AD RID: 2477
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDecomposeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009AE RID: 2478
		public new static readonly string MRClassNameKey = "class vtkImageDecomposeFilter";
	}
}
