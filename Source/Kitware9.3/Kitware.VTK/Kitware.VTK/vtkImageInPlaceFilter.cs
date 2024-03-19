using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageInPlaceFilter
	/// </summary>
	/// <remarks>
	///    Filter that operates in place.
	///
	/// vtkImageInPlaceFilter is a filter super class that
	/// operates directly on the input region.  The data is copied
	/// if the requested region has different extent than the input region
	/// or some other object is referencing the input region.
	/// </remarks>
	// Token: 0x020003E2 RID: 994
	public class vtkImageInPlaceFilter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BEA0 RID: 48800 RVA: 0x00109B23 File Offset: 0x00107D23
		static vtkImageInPlaceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageInPlaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageInPlaceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BEA1 RID: 48801 RVA: 0x00109B4B File Offset: 0x00107D4B
		public vtkImageInPlaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BEA2 RID: 48802 RVA: 0x00109B59 File Offset: 0x00107D59
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BEA3 RID: 48803
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageInPlaceFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEA4 RID: 48804 RVA: 0x00109B64 File Offset: 0x00107D64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageInPlaceFilter.vtkImageInPlaceFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600BEA5 RID: 48805
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageInPlaceFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEA6 RID: 48806 RVA: 0x00109B84 File Offset: 0x00107D84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageInPlaceFilter.vtkImageInPlaceFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600BEA7 RID: 48807
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageInPlaceFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEA8 RID: 48808 RVA: 0x00109BA0 File Offset: 0x00107DA0
		public override int IsA(string type)
		{
			return vtkImageInPlaceFilter.vtkImageInPlaceFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600BEA9 RID: 48809
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageInPlaceFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEAA RID: 48810 RVA: 0x00109BC0 File Offset: 0x00107DC0
		public new static int IsTypeOf(string type)
		{
			return vtkImageInPlaceFilter.vtkImageInPlaceFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600BEAB RID: 48811
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageInPlaceFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEAC RID: 48812 RVA: 0x00109BDC File Offset: 0x00107DDC
		public new vtkImageInPlaceFilter NewInstance()
		{
			vtkImageInPlaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageInPlaceFilter.vtkImageInPlaceFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageInPlaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BEAD RID: 48813
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageInPlaceFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEAE RID: 48814 RVA: 0x00109C38 File Offset: 0x00107E38
		public new static vtkImageInPlaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageInPlaceFilter vtkImageInPlaceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageInPlaceFilter.vtkImageInPlaceFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageInPlaceFilter = (vtkImageInPlaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageInPlaceFilter.Register(null);
				}
			}
			return vtkImageInPlaceFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E31 RID: 3633
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageInPlaceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E32 RID: 3634
		public new static readonly string MRClassNameKey = "class vtkImageInPlaceFilter";
	}
}
