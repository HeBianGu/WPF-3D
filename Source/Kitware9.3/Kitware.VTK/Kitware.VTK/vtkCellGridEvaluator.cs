using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridEvaluator
	/// </summary>
	/// <remarks>
	///    Evaluate a field (vtkCellAttribute) at some points inside cells.
	///
	/// This class is a cell-grid query whose purpose is to determine the
	/// value a vtkCellAttribute takes on at one or more points inside
	/// the domain of a vtkCellGrid.
	///
	/// This class performs its work in two phases:
	/// + Classification. Input points are classified by the type and index
	///   of cell in the grid in which they lie.
	/// + Attribute/field interpolation. Each cell is asked to interpolate
	///   the value of a cell-attribute at each point classified to it.
	///
	/// As an example, consider a cell-grid holding 10 triangles and 20 quads
	/// and a query that is provided 5 points. The first phase will identify
	/// which of the 5 points are insides triangles, which lie in quadrilaterals,
	/// and which lie in neither. Say that 2 lie inside triangles, 2 inside
	/// quadrilaterals, and 1 is outside the domain.
	/// Furthermore, the first phase will identify which particular triangles
	/// or quadrilaterals contain the input points. The two points which
	/// lie in triangles will report a number in [0,10[ while the two points
	/// which lie in quadrilaterals will report a number in [0, 20[.
	/// Finally, for cells which have a reference element, the parametric
	/// coordinates of each input point are computed.
	///
	/// The second phase additionally interpolates a cell-attribute (let's
	/// say "Velocity" in our example) at each input point.
	///
	/// You may configure the query to skip either phase (classification or
	/// interpolation). If you skip classification, you must provide the
	/// the classification information for the input points.
	/// The method you call (ClassifyPoints, InterpolatePoints, or
	/// InterpolateCellParameters) determines which phase(s) are applied
	/// during evaluation.
	///
	/// When running in InterpolatePoints mode (both classification and
	/// interpolation phases are performed), the output from our example
	/// is reported like so:
	///
	/// + `GetClassifierCellTypes()` – returns an array with a cell-type hash
	///   for each type of cell containing an input point. The hash value can
	///   be used to construct a vtkStringToken.
	///   Our example would return an array with 3 values which might be
	///   ordered: "vtkDGTri"_hash, "vtkDGQuad"_hash, and 0 (an "invalid" hash).
	/// + `GetClassifierCellOffsets()` – returns an array with the same number
	///   of values as the call above. Each value specifies the start of
	///   reporting for points contained in the corresponding cell type.
	///   Our example would return [0, 2, 4] to match the values above.
	/// + `GetClassifierPointIDs()` – returns an array whose length matches
	///   the number of input points. Each value is the index of an input
	///   point. Input points do not have their order preserved so that
	///   all the points contained in a single cell can be reported together.
	///   Our example might return [4, 2, 1, 0, 3]. This will always be a
	///   permutation of the counting integers and, for our example, always
	///   hold integers in [0, 5[.
	/// + `GetClassifierCellIndices()` – returns an array whose length matches
	///   the number of input points. Each value is the index into cells
	///   of the corresponding type, indicating which cell contains
	///   the input point.
	///   For our example, the first two numbers will be in [0, 10[, the second
	///   two will be in [0, 20[, and the last will be -1. (This is because
	///   we have two points inside 10 triangles, two points inside 20 quads,
	///   and one un-classifiable input point.)
	/// + `GetClassifierPointParameters()` – returns an array whose length
	///   matches the number of input points. Each value is a 3-tuple of
	///   reference-cell coordinates (or indeterminate if the cell type does
	///   not provide a reference cell).
	/// + `GetInterpolatedValues()` – returns an array whose number of tuples
	///   matches the number of input points and whose number of components
	///   matches the number of components of the requested cell-attribute.
	///   For our example, an array with 5 tuples of 3 components each would be
	///   returned; it would be named "Velocity" (matching the cell-attribute's
	///   name).
	///
	/// Note that because you can pass in the arrays above (except the interpolated
	/// values) to short-circuit classification, it is possible to evaluate
	/// multiple cell-attributes without duplicating the classification work.
	///
	/// In InterpolateCellParameters mode, calling the methods above which begin
	/// with `GetClassifier…` will simply return the input arrays you passed to
	/// configure the query.
	///
	/// ## Warnings
	///
	/// The output arrays above generally match the number of input points, but
	/// will sometimes exceed the number of input points. This will occur when
	/// multiple cells contain an input point (either on a shared boundary or
	/// because the cells overlap).
	///
	/// Note that the output should never have fewer points than the input as
	/// even points outside the cells will be classified as such.
	///
	/// Currently, this class is limited to evaluating numeric attributes;
	/// string or variant arrays are not supported.
	/// </remarks>
	// Token: 0x02000A20 RID: 2592
	public class vtkCellGridEvaluator : vtkCellGridQuery
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B06E RID: 110702 RVA: 0x0025B53F File Offset: 0x0025973F
		static vtkCellGridEvaluator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridEvaluator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridEvaluator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B06F RID: 110703 RVA: 0x0025B567 File Offset: 0x00259767
		public vtkCellGridEvaluator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B070 RID: 110704
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B071 RID: 110705 RVA: 0x0025B578 File Offset: 0x00259778
		public new static vtkCellGridEvaluator New()
		{
			vtkCellGridEvaluator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridEvaluator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B072 RID: 110706 RVA: 0x0025B5CC File Offset: 0x002597CC
		public vtkCellGridEvaluator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridEvaluator.vtkCellGridEvaluator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B073 RID: 110707 RVA: 0x0025B610 File Offset: 0x00259810
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B074 RID: 110708
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridEvaluator_ClassifyPoints_01(HandleRef pThis, HandleRef points);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B075 RID: 110709 RVA: 0x0025B61C File Offset: 0x0025981C
		public void ClassifyPoints(vtkDataArray points)
		{
			vtkCellGridEvaluator.vtkCellGridEvaluator_ClassifyPoints_01(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x0601B076 RID: 110710
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridEvaluator_Finalize_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B077 RID: 110711 RVA: 0x0025B64B File Offset: 0x0025984B
		public override void FinalizeWrapper()
		{
			vtkCellGridEvaluator.vtkCellGridEvaluator_Finalize_02(base.GetCppThis());
		}

		// Token: 0x0601B078 RID: 110712
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_GetCellAttribute_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B079 RID: 110713 RVA: 0x0025B65C File Offset: 0x0025985C
		public virtual vtkCellAttribute GetCellAttribute()
		{
			vtkCellAttribute vtkCellAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_GetCellAttribute_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttribute = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttribute.Register(null);
				}
			}
			return vtkCellAttribute;
		}

		// Token: 0x0601B07A RID: 110714
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_GetClassifierCellIndices_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B07B RID: 110715 RVA: 0x0025B6CC File Offset: 0x002598CC
		public virtual vtkTypeUInt64Array GetClassifierCellIndices()
		{
			vtkTypeUInt64Array vtkTypeUInt64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_GetClassifierCellIndices_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt64Array = (vtkTypeUInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt64Array.Register(null);
				}
			}
			return vtkTypeUInt64Array;
		}

		// Token: 0x0601B07C RID: 110716
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_GetClassifierCellOffsets_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B07D RID: 110717 RVA: 0x0025B73C File Offset: 0x0025993C
		public virtual vtkTypeUInt64Array GetClassifierCellOffsets()
		{
			vtkTypeUInt64Array vtkTypeUInt64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_GetClassifierCellOffsets_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt64Array = (vtkTypeUInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt64Array.Register(null);
				}
			}
			return vtkTypeUInt64Array;
		}

		// Token: 0x0601B07E RID: 110718
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_GetClassifierCellTypes_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B07F RID: 110719 RVA: 0x0025B7AC File Offset: 0x002599AC
		public virtual vtkTypeUInt32Array GetClassifierCellTypes()
		{
			vtkTypeUInt32Array vtkTypeUInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_GetClassifierCellTypes_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt32Array = (vtkTypeUInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt32Array.Register(null);
				}
			}
			return vtkTypeUInt32Array;
		}

		// Token: 0x0601B080 RID: 110720
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_GetClassifierPointIDs_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B081 RID: 110721 RVA: 0x0025B81C File Offset: 0x00259A1C
		public virtual vtkTypeUInt64Array GetClassifierPointIDs()
		{
			vtkTypeUInt64Array vtkTypeUInt64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_GetClassifierPointIDs_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt64Array = (vtkTypeUInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt64Array.Register(null);
				}
			}
			return vtkTypeUInt64Array;
		}

		// Token: 0x0601B082 RID: 110722
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_GetClassifierPointParameters_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B083 RID: 110723 RVA: 0x0025B88C File Offset: 0x00259A8C
		public virtual vtkDataArray GetClassifierPointParameters()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_GetClassifierPointParameters_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0601B084 RID: 110724
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_GetInputPoints_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B085 RID: 110725 RVA: 0x0025B8FC File Offset: 0x00259AFC
		public virtual vtkDataArray GetInputPoints()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_GetInputPoints_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0601B086 RID: 110726
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_GetInterpolatedValues_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B087 RID: 110727 RVA: 0x0025B96C File Offset: 0x00259B6C
		public virtual vtkDataArray GetInterpolatedValues()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_GetInterpolatedValues_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0601B088 RID: 110728
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_GetLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B089 RID: 110729 RVA: 0x0025B9DC File Offset: 0x00259BDC
		public virtual vtkStaticPointLocator GetLocator()
		{
			vtkStaticPointLocator vtkStaticPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_GetLocator_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStaticPointLocator = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStaticPointLocator.Register(null);
				}
			}
			return vtkStaticPointLocator;
		}

		// Token: 0x0601B08A RID: 110730
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridEvaluator_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B08B RID: 110731 RVA: 0x0025BA4C File Offset: 0x00259C4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridEvaluator.vtkCellGridEvaluator_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601B08C RID: 110732
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridEvaluator_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B08D RID: 110733 RVA: 0x0025BA6C File Offset: 0x00259C6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridEvaluator.vtkCellGridEvaluator_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601B08E RID: 110734
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellGridEvaluator.Phases vtkCellGridEvaluator_GetPhasesToPerform_14(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B08F RID: 110735 RVA: 0x0025BA88 File Offset: 0x00259C88
		public virtual vtkCellGridEvaluator.Phases GetPhasesToPerform()
		{
			return vtkCellGridEvaluator.vtkCellGridEvaluator_GetPhasesToPerform_14(base.GetCppThis());
		}

		// Token: 0x0601B090 RID: 110736
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridEvaluator_Initialize_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B091 RID: 110737 RVA: 0x0025BAA7 File Offset: 0x00259CA7
		public override void Initialize()
		{
			vtkCellGridEvaluator.vtkCellGridEvaluator_Initialize_15(base.GetCppThis());
		}

		// Token: 0x0601B092 RID: 110738
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridEvaluator_InterpolateCellParameters_16(HandleRef pThis, HandleRef cellTypes, HandleRef cellOffsets, HandleRef cellIndices, HandleRef pointParameters);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B093 RID: 110739 RVA: 0x0025BAB8 File Offset: 0x00259CB8
		public void InterpolateCellParameters(vtkTypeUInt32Array cellTypes, vtkTypeUInt64Array cellOffsets, vtkTypeUInt64Array cellIndices, vtkDataArray pointParameters)
		{
			vtkCellGridEvaluator.vtkCellGridEvaluator_InterpolateCellParameters_16(base.GetCppThis(), (cellTypes == null) ? default(HandleRef) : cellTypes.GetCppThis(), (cellOffsets == null) ? default(HandleRef) : cellOffsets.GetCppThis(), (cellIndices == null) ? default(HandleRef) : cellIndices.GetCppThis(), (pointParameters == null) ? default(HandleRef) : pointParameters.GetCppThis());
		}

		// Token: 0x0601B094 RID: 110740
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridEvaluator_InterpolatePoints_17(HandleRef pThis, HandleRef points);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B095 RID: 110741 RVA: 0x0025BB28 File Offset: 0x00259D28
		public void InterpolatePoints(vtkDataArray points)
		{
			vtkCellGridEvaluator.vtkCellGridEvaluator_InterpolatePoints_17(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x0601B096 RID: 110742
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridEvaluator_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B097 RID: 110743 RVA: 0x0025BB58 File Offset: 0x00259D58
		public override int IsA(string type)
		{
			return vtkCellGridEvaluator.vtkCellGridEvaluator_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0601B098 RID: 110744
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGridEvaluator_IsAnotherPassRequired_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B099 RID: 110745 RVA: 0x0025BB78 File Offset: 0x00259D78
		public override bool IsAnotherPassRequired()
		{
			return vtkCellGridEvaluator.vtkCellGridEvaluator_IsAnotherPassRequired_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0601B09A RID: 110746
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridEvaluator_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B09B RID: 110747 RVA: 0x0025BBA0 File Offset: 0x00259DA0
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridEvaluator.vtkCellGridEvaluator_IsTypeOf_20(type);
		}

		// Token: 0x0601B09C RID: 110748
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B09D RID: 110749 RVA: 0x0025BBBC File Offset: 0x00259DBC
		public new vtkCellGridEvaluator NewInstance()
		{
			vtkCellGridEvaluator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridEvaluator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B09E RID: 110750
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridEvaluator_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B09F RID: 110751 RVA: 0x0025BC18 File Offset: 0x00259E18
		public new static vtkCellGridEvaluator SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridEvaluator vtkCellGridEvaluator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridEvaluator.vtkCellGridEvaluator_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridEvaluator = (vtkCellGridEvaluator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridEvaluator.Register(null);
				}
			}
			return vtkCellGridEvaluator;
		}

		// Token: 0x0601B0A0 RID: 110752
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridEvaluator_SetCellAttribute_24(HandleRef pThis, HandleRef _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0A1 RID: 110753 RVA: 0x0025BC98 File Offset: 0x00259E98
		public virtual void SetCellAttribute(vtkCellAttribute _arg)
		{
			vtkCellGridEvaluator.vtkCellGridEvaluator_SetCellAttribute_24(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601B0A2 RID: 110754
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridEvaluator_StartPass_25(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0A3 RID: 110755 RVA: 0x0025BCC7 File Offset: 0x00259EC7
		public override void StartPass()
		{
			vtkCellGridEvaluator.vtkCellGridEvaluator_StartPass_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D2F RID: 7471
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridEvaluator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D30 RID: 7472
		public new static readonly string MRClassNameKey = "class vtkCellGridEvaluator";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000A21 RID: 2593
		public enum Phases
		{
			/// <summary>enum member</summary>
			// Token: 0x04001D32 RID: 7474
			Classify = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001D33 RID: 7475
			ClassifyAndInterpolate,
			/// <summary>enum member</summary>
			// Token: 0x04001D34 RID: 7476
			Interpolate,
			/// <summary>enum member</summary>
			// Token: 0x04001D35 RID: 7477
			None = 0
		}
	}
}
