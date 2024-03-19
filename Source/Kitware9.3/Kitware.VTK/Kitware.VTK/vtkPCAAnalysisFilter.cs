using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPCAAnalysisFilter
	/// </summary>
	/// <remarks>
	///    Performs principal component analysis of a set of aligned pointsets
	///
	///
	/// vtkPCAAnalysisFilter is a filter that takes as input a set of aligned
	/// pointsets (any object derived from vtkPointSet) and performs
	/// a principal component analysis of the coordinates.
	/// This can be used to visualise the major or minor modes of variation
	/// seen in a set of similar biological objects with corresponding
	/// landmarks.
	/// vtkPCAAnalysisFilter is designed to work with the output from
	/// the vtkProcrustesAnalysisFilter
	/// vtkPCAAnalysisFilter requires a vtkMultiBlock input consisting
	/// of vtkPointSets as first level children.
	///
	/// vtkPCAAnalysisFilter is an implementation of (for example):
	///
	/// T. Cootes et al. : Active Shape Models - their training and application.
	/// Computer Vision and Image Understanding, 61(1):38-59, 1995.
	///
	/// The material can also be found in Tim Cootes' ever-changing online report
	/// published at his website:
	/// http://www.isbe.man.ac.uk/~bim/
	///
	/// @warning
	/// All of the input pointsets must have the same number of points.
	///
	/// @par Thanks:
	/// Rasmus Paulsen and Tim Hutton who developed and contributed this class
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProcrustesAlignmentFilter
	/// </seealso>
	// Token: 0x02000610 RID: 1552
	public class vtkPCAAnalysisFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010E12 RID: 69138 RVA: 0x0017845A File Offset: 0x0017665A
		static vtkPCAAnalysisFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCAAnalysisFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCAAnalysisFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010E13 RID: 69139 RVA: 0x00178482 File Offset: 0x00176682
		public vtkPCAAnalysisFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010E14 RID: 69140
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAAnalysisFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates with similarity transform.
		/// </summary>
		// Token: 0x06010E15 RID: 69141 RVA: 0x00178490 File Offset: 0x00176690
		public new static vtkPCAAnalysisFilter New()
		{
			vtkPCAAnalysisFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCAAnalysisFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates with similarity transform.
		/// </summary>
		// Token: 0x06010E16 RID: 69142 RVA: 0x001784E4 File Offset: 0x001766E4
		public vtkPCAAnalysisFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010E17 RID: 69143 RVA: 0x00178528 File Offset: 0x00176728
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010E18 RID: 69144
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAAnalysisFilter_GetEvals_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vector of eigenvalues sorted in descending order
		/// </summary>
		// Token: 0x06010E19 RID: 69145 RVA: 0x00178534 File Offset: 0x00176734
		public virtual vtkFloatArray GetEvals()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetEvals_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x06010E1A RID: 69146
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCAAnalysisFilter_GetModesRequiredFor_02(HandleRef pThis, double proportion);

		/// <summary>
		/// Retrieve how many modes are necessary to model the given proportion of the variation.
		/// proportion should be between 0 and 1
		/// </summary>
		// Token: 0x06010E1B RID: 69147 RVA: 0x001785A4 File Offset: 0x001767A4
		public int GetModesRequiredFor(double proportion)
		{
			return vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetModesRequiredFor_02(base.GetCppThis(), proportion);
		}

		// Token: 0x06010E1C RID: 69148
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCAAnalysisFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E1D RID: 69149 RVA: 0x001785C4 File Offset: 0x001767C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06010E1E RID: 69150
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCAAnalysisFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E1F RID: 69151 RVA: 0x001785E4 File Offset: 0x001767E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06010E20 RID: 69152
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAAnalysisFilter_GetParameterisedShape_05(HandleRef pThis, HandleRef b, HandleRef shape);

		/// <summary>
		/// Fills the shape with:
		///
		/// mean + b[0] * sqrt(eigenvalue[0]) * eigenvector[0]
		/// + b[1] * sqrt(eigenvalue[1]) * eigenvector[1]
		/// ...
		/// + b[sizeb-1] * sqrt(eigenvalue[bsize-1]) * eigenvector[bsize-1]
		///
		/// here b are the parameters expressed in standard deviations
		/// bsize is the number of parameters in the b vector
		/// This function assumes that shape is already allocated
		/// with the right size, it just moves the points.
		/// </summary>
		// Token: 0x06010E21 RID: 69153 RVA: 0x00178600 File Offset: 0x00176800
		public void GetParameterisedShape(vtkFloatArray b, vtkPointSet shape)
		{
			vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetParameterisedShape_05(base.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), (shape == null) ? default(HandleRef) : shape.GetCppThis());
		}

		// Token: 0x06010E22 RID: 69154
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCAAnalysisFilter_GetShapeParameters_06(HandleRef pThis, HandleRef shape, HandleRef b, int bsize);

		/// <summary>
		/// Return the bsize parameters b that best model the given shape
		/// (in standard deviations).
		/// That is that the given shape will be approximated by:
		///
		/// shape ~ mean + b[0] * sqrt(eigenvalue[0]) * eigenvector[0]
		/// + b[1] * sqrt(eigenvalue[1]) * eigenvector[1]
		/// ...
		/// + b[bsize-1] * sqrt(eigenvalue[bsize-1]) * eigenvector[bsize-1]
		/// </summary>
		// Token: 0x06010E23 RID: 69155 RVA: 0x00178644 File Offset: 0x00176844
		public void GetShapeParameters(vtkPointSet shape, vtkFloatArray b, int bsize)
		{
			vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_GetShapeParameters_06(base.GetCppThis(), (shape == null) ? default(HandleRef) : shape.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), bsize);
		}

		// Token: 0x06010E24 RID: 69156
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCAAnalysisFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E25 RID: 69157 RVA: 0x0017868C File Offset: 0x0017688C
		public override int IsA(string type)
		{
			return vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06010E26 RID: 69158
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCAAnalysisFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E27 RID: 69159 RVA: 0x001786AC File Offset: 0x001768AC
		public new static int IsTypeOf(string type)
		{
			return vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_IsTypeOf_08(type);
		}

		// Token: 0x06010E28 RID: 69160
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAAnalysisFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E29 RID: 69161 RVA: 0x001786C8 File Offset: 0x001768C8
		public new vtkPCAAnalysisFilter NewInstance()
		{
			vtkPCAAnalysisFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCAAnalysisFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010E2A RID: 69162
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCAAnalysisFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010E2B RID: 69163 RVA: 0x00178724 File Offset: 0x00176924
		public new static vtkPCAAnalysisFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPCAAnalysisFilter vtkPCAAnalysisFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCAAnalysisFilter.vtkPCAAnalysisFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCAAnalysisFilter = (vtkPCAAnalysisFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCAAnalysisFilter.Register(null);
				}
			}
			return vtkPCAAnalysisFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400137A RID: 4986
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCAAnalysisFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400137B RID: 4987
		public new static readonly string MRClassNameKey = "class vtkPCAAnalysisFilter";
	}
}
