using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDataOutlineFilter
	/// </summary>
	/// <remarks>
	///    create wireframe outline for a possibly oriented vtkImageData
	///
	/// vtkImageDataOutlineFilter is a filter that generates a wireframe outline
	/// of vtkImageData. It takes into account the orientation / DirectionMatrix
	/// of the image, so the output outline may not be axes aligned.  The outline
	/// consists of the twelve edges of the vtkImageData. Optionally, the six
	/// bounding faces of the vtkImageData can be produced as well.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOutlineFilter
	/// </seealso>
	// Token: 0x02000559 RID: 1369
	public class vtkImageDataOutlineFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F301 RID: 62209 RVA: 0x00152915 File Offset: 0x00150B15
		static vtkImageDataOutlineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataOutlineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F302 RID: 62210 RVA: 0x0015293D File Offset: 0x00150B3D
		public vtkImageDataOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F303 RID: 62211
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F304 RID: 62212 RVA: 0x0015294C File Offset: 0x00150B4C
		public new static vtkImageDataOutlineFilter New()
		{
			vtkImageDataOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F305 RID: 62213 RVA: 0x001529A0 File Offset: 0x00150BA0
		public vtkImageDataOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F306 RID: 62214 RVA: 0x001529E4 File Offset: 0x00150BE4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F307 RID: 62215
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataOutlineFilter_GenerateFacesOff_01(HandleRef pThis);

		/// <summary>
		/// Generate the six boundary faces of the image data. This is off by default.
		/// </summary>
		// Token: 0x0600F308 RID: 62216 RVA: 0x001529EF File Offset: 0x00150BEF
		public virtual void GenerateFacesOff()
		{
			vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_GenerateFacesOff_01(base.GetCppThis());
		}

		// Token: 0x0600F309 RID: 62217
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataOutlineFilter_GenerateFacesOn_02(HandleRef pThis);

		/// <summary>
		/// Generate the six boundary faces of the image data. This is off by default.
		/// </summary>
		// Token: 0x0600F30A RID: 62218 RVA: 0x001529FE File Offset: 0x00150BFE
		public virtual void GenerateFacesOn()
		{
			vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_GenerateFacesOn_02(base.GetCppThis());
		}

		// Token: 0x0600F30B RID: 62219
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataOutlineFilter_GetGenerateFaces_03(HandleRef pThis);

		/// <summary>
		/// Generate the six boundary faces of the image data. This is off by default.
		/// </summary>
		// Token: 0x0600F30C RID: 62220 RVA: 0x00152A10 File Offset: 0x00150C10
		public virtual int GetGenerateFaces()
		{
			return vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_GetGenerateFaces_03(base.GetCppThis());
		}

		// Token: 0x0600F30D RID: 62221
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataOutlineFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F30E RID: 62222 RVA: 0x00152A30 File Offset: 0x00150C30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F30F RID: 62223
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataOutlineFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F310 RID: 62224 RVA: 0x00152A50 File Offset: 0x00150C50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600F311 RID: 62225
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataOutlineFilter_GetOutputPointsPrecision_06(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0600F312 RID: 62226 RVA: 0x00152A6C File Offset: 0x00150C6C
		public virtual int GetOutputPointsPrecision()
		{
			return vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_GetOutputPointsPrecision_06(base.GetCppThis());
		}

		// Token: 0x0600F313 RID: 62227
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataOutlineFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F314 RID: 62228 RVA: 0x00152A8C File Offset: 0x00150C8C
		public override int IsA(string type)
		{
			return vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600F315 RID: 62229
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataOutlineFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F316 RID: 62230 RVA: 0x00152AAC File Offset: 0x00150CAC
		public new static int IsTypeOf(string type)
		{
			return vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_IsTypeOf_08(type);
		}

		// Token: 0x0600F317 RID: 62231
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataOutlineFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F318 RID: 62232 RVA: 0x00152AC8 File Offset: 0x00150CC8
		public new vtkImageDataOutlineFilter NewInstance()
		{
			vtkImageDataOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F319 RID: 62233
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataOutlineFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F31A RID: 62234 RVA: 0x00152B24 File Offset: 0x00150D24
		public new static vtkImageDataOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataOutlineFilter vtkImageDataOutlineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataOutlineFilter = (vtkImageDataOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataOutlineFilter.Register(null);
				}
			}
			return vtkImageDataOutlineFilter;
		}

		// Token: 0x0600F31B RID: 62235
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataOutlineFilter_SetGenerateFaces_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Generate the six boundary faces of the image data. This is off by default.
		/// </summary>
		// Token: 0x0600F31C RID: 62236 RVA: 0x00152BA3 File Offset: 0x00150DA3
		public virtual void SetGenerateFaces(int _arg)
		{
			vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_SetGenerateFaces_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F31D RID: 62237
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataOutlineFilter_SetOutputPointsPrecision_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0600F31E RID: 62238 RVA: 0x00152BB3 File Offset: 0x00150DB3
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkImageDataOutlineFilter.vtkImageDataOutlineFilter_SetOutputPointsPrecision_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011B4 RID: 4532
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataOutlineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011B5 RID: 4533
		public new static readonly string MRClassNameKey = "class vtkImageDataOutlineFilter";
	}
}
