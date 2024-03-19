using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageFourierFilter
	/// </summary>
	/// <remarks>
	///    Superclass that implements complex numbers.
	///
	/// vtkImageFourierFilter is a class of filters that use complex numbers
	/// this superclass is a container for methods that manipulate these structure
	/// including fast Fourier transforms.  Complex numbers may become a class.
	/// This should really be a helper class.
	/// </remarks>
	// Token: 0x0200025D RID: 605
	public class vtkImageFourierFilter : vtkImageDecomposeFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006FB5 RID: 28597 RVA: 0x000A0DF3 File Offset: 0x0009EFF3
		static vtkImageFourierFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageFourierFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageFourierFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006FB6 RID: 28598 RVA: 0x000A0E1B File Offset: 0x0009F01B
		public vtkImageFourierFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006FB7 RID: 28599 RVA: 0x000A0E29 File Offset: 0x0009F029
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006FB8 RID: 28600
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageFourierFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FB9 RID: 28601 RVA: 0x000A0E34 File Offset: 0x0009F034
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageFourierFilter.vtkImageFourierFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006FBA RID: 28602
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageFourierFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FBB RID: 28603 RVA: 0x000A0E54 File Offset: 0x0009F054
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageFourierFilter.vtkImageFourierFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006FBC RID: 28604
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFourierFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FBD RID: 28605 RVA: 0x000A0E70 File Offset: 0x0009F070
		public override int IsA(string type)
		{
			return vtkImageFourierFilter.vtkImageFourierFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006FBE RID: 28606
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFourierFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FBF RID: 28607 RVA: 0x000A0E90 File Offset: 0x0009F090
		public new static int IsTypeOf(string type)
		{
			return vtkImageFourierFilter.vtkImageFourierFilter_IsTypeOf_04(type);
		}

		// Token: 0x06006FC0 RID: 28608
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFourierFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FC1 RID: 28609 RVA: 0x000A0EAC File Offset: 0x0009F0AC
		public new vtkImageFourierFilter NewInstance()
		{
			vtkImageFourierFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFourierFilter.vtkImageFourierFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFourierFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006FC2 RID: 28610
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFourierFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FC3 RID: 28611 RVA: 0x000A0F08 File Offset: 0x0009F108
		public new static vtkImageFourierFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageFourierFilter vtkImageFourierFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFourierFilter.vtkImageFourierFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageFourierFilter = (vtkImageFourierFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageFourierFilter.Register(null);
				}
			}
			return vtkImageFourierFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009AF RID: 2479
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageFourierFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B0 RID: 2480
		public new static readonly string MRClassNameKey = "class vtkImageFourierFilter";
	}
}
