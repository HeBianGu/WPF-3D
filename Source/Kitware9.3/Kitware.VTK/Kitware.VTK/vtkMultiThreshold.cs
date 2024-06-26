﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiThreshold
	/// </summary>
	/// <remarks>
	///    Threshold cells within multiple intervals
	///
	/// This filter can be substituted for a chain of several vtkThreshold filters
	/// and can also perform more sophisticated subsetting operations.
	/// It generates a vtkMultiBlockDataSet as its output.
	/// This multiblock dataset contains a vtkUnstructuredGrid for each thresholded
	/// subset you request.
	/// A thresholded subset can be a set defined by an interval over a
	/// point or cell attribute of the mesh; these subsets are called IntervalSets.
	/// A thresholded subset can also be a boolean combination of one or more IntervalSets;
	/// these subsets are called BooleanSets.
	/// BooleanSets allow complex logic since their output
	/// can depend on multiple intervals over multiple variables
	/// defined on the input mesh.
	/// This is useful because it eliminates the need for thresholding several
	/// times and then appending the results, as can be required with vtkThreshold
	/// when one wants to remove some range of values (e.g., a notch filter).
	/// Cells are not repeated when they belong to more than one interval unless
	/// those intervals have different output grids.
	///
	/// Another advantage this filter provides over vtkThreshold is the ability
	/// to threshold on non-scalar (i.e., vector, tensor, etc.) attributes without
	/// first computing an array containing some norm of the desired attribute.
	/// vtkMultiThreshold provides \f$L_1\f$, \f$L_2\f$, and \f$L_{\infty}\f$ norms.
	///
	/// This filter makes a distinction between intermediate subsets and
	/// subsets that will be output to a grid.
	/// Each intermediate subset you create with AddIntervalSet or
	/// AddBooleanSet is given a unique integer identifier (via the return
	/// values of these member functions).
	/// If you wish for a given set to be output, you must call
	/// OutputSet and pass it one of these identifiers.
	/// The return of OutputSet is the integer index of the output set
	/// in the multiblock dataset created by this filter.
	///
	/// For example, if an input mesh defined three attributes T, P, and s, one might
	/// wish to find cells that satisfy "T &lt; 320 [K] &amp;&amp; ( P &gt; 101 [kPa] || s &lt; 0.1 [kJ/kg/K] )".
	/// To accomplish this with a vtkMultiThreshold filter,
	/// &lt;pre&gt;
	/// vtkMultiThreshold* thr;
	/// int intervalSets[3];
	///
	/// intervalSets[0] = thr-&gt;AddIntervalSet( vtkMath::NegInf(), 320., vtkMultiThreshold::CLOSED,
	/// vtkMultiThreshold::OPEN, vtkDataObject::FIELD_ASSOCIATION_POINTS, "T", 0, 1 ); intervalSets[1] =
	/// thr-&gt;AddIntervalSet( 101., vtkMath::Inf(), vtkMultiThreshold::OPEN, vtkMultiThreshold::CLOSED,
	///     vtkDataObject::FIELD_ASSOCIATION_CELLS, "P", 0, 1 );
	/// intervalSets[2] = thr-&gt;AddIntervalSet( vtkMath::NegInf(), 0.1, vtkMultiThreshold::CLOSED,
	/// vtkMultiThreshold::OPEN, vtkDataObject::FIELD_ASSOCIATION_POINTS, "s", 0, 1 );
	///
	/// int intermediate = thr-&gt;AddBooleanSet( vtkMultiThreshold::OR, 2, &amp;intervalSets[1] );
	///
	/// int intersection[2];
	/// intersection[0] = intervalSets[0];
	/// intersection[1] = intermediate;
	/// int outputSet = thr-&gt;AddBooleanSet( vtkMultiThreshold::AND, 2, intersection );
	///
	/// int outputGridIndex = thr-&gt;OutputSet( outputSet );
	/// thr-&gt;Update();
	/// &lt;/pre&gt;
	/// The result of this filter will be a multiblock dataset that contains a single child with the
	/// desired cells. If we had also called &lt;code&gt;thr-&gt;OutputSet( intervalSets[0] );&lt;/code&gt;, there would
	/// be two child meshes and one would contain all cells with T &lt; 320 [K]. In that case, the output
	/// can be represented by this graph
	///
	/// \dot
	/// digraph MultiThreshold {
	///   set0 [shape=rect,style=filled,label="point T(0) in [-Inf,320["]
	///   set1 [shape=rect,label="cell P(0) in ]101,Inf]"]
	///   set2 [shape=rect,label="point s(0) in [-Inf,0.1["]
	///   set3 [shape=rect,label="OR"]
	///   set4 [shape=rect,style=filled,label="AND"]
	///   set0 -&gt; set4
	///   set1 -&gt; set3
	///   set2 -&gt; set3
	///   set3 -&gt; set4
	/// }
	/// \enddot
	///
	/// The filled rectangles represent sets that are output.
	/// </remarks>
	// Token: 0x020008BF RID: 2239
	public class vtkMultiThreshold : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017326 RID: 95014 RVA: 0x00209027 File Offset: 0x00207227
		static vtkMultiThreshold()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiThreshold.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiThreshold"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017327 RID: 95015 RVA: 0x0020904F File Offset: 0x0020724F
		public vtkMultiThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017328 RID: 95016
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017329 RID: 95017 RVA: 0x00209060 File Offset: 0x00207260
		public new static vtkMultiThreshold New()
		{
			vtkMultiThreshold result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiThreshold.vtkMultiThreshold_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601732A RID: 95018 RVA: 0x002090B4 File Offset: 0x002072B4
		public vtkMultiThreshold() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiThreshold.vtkMultiThreshold_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601732B RID: 95019 RVA: 0x002090F8 File Offset: 0x002072F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601732C RID: 95020
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_AddBandpassIntervalSet_01(HandleRef pThis, double xmin, double xmax, int assoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component, int allScalars);

		/// <summary>
		/// These convenience members make it easy to insert closed intervals.
		/// The "notch" interval is accomplished by creating a bandpass interval and applying a NAND
		/// operation. In this case, the set ID returned in the NAND operation set ID. Note that you can
		/// pass xmin == xmax when creating a bandpass threshold to retrieve elements matching exactly one
		/// value (since the intervals created by these routines are closed).
		/// </summary>
		// Token: 0x0601732D RID: 95021 RVA: 0x00209104 File Offset: 0x00207304
		public int AddBandpassIntervalSet(double xmin, double xmax, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddBandpassIntervalSet_01(base.GetCppThis(), xmin, xmax, assoc, arrayName, component, allScalars);
		}

		// Token: 0x0601732E RID: 95022
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_AddBooleanSet_02(HandleRef pThis, int operation, int numInputs, IntPtr inputs);

		/// <summary>
		/// Create a new mesh subset using boolean operations on pre-existing sets.
		/// </summary>
		// Token: 0x0601732F RID: 95023 RVA: 0x0020912C File Offset: 0x0020732C
		public int AddBooleanSet(int operation, int numInputs, IntPtr inputs)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddBooleanSet_02(base.GetCppThis(), operation, numInputs, inputs);
		}

		// Token: 0x06017330 RID: 95024
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_AddHighpassIntervalSet_03(HandleRef pThis, double xmin, int assoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component, int allScalars);

		/// <summary>
		/// These convenience members make it easy to insert closed intervals.
		/// The "notch" interval is accomplished by creating a bandpass interval and applying a NAND
		/// operation. In this case, the set ID returned in the NAND operation set ID. Note that you can
		/// pass xmin == xmax when creating a bandpass threshold to retrieve elements matching exactly one
		/// value (since the intervals created by these routines are closed).
		/// </summary>
		// Token: 0x06017331 RID: 95025 RVA: 0x00209150 File Offset: 0x00207350
		public int AddHighpassIntervalSet(double xmin, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddHighpassIntervalSet_03(base.GetCppThis(), xmin, assoc, arrayName, component, allScalars);
		}

		// Token: 0x06017332 RID: 95026
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_AddIntervalSet_04(HandleRef pThis, double xmin, double xmax, int omin, int omax, int assoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component, int allScalars);

		/// <summary>
		/// Add a mesh subset to be computed by thresholding an attribute of the input mesh.
		/// The subset can then be added to an output mesh with OutputSet() or
		/// combined with other sets using AddBooleanSet.
		/// If you wish to include all cells with values below some number \a a, call
		/// with xmin set to vtkMath::NegInf() and xmax set to \a a.
		/// Similarly, if you wish to include all cells with values above some number \a a,
		/// call with xmin set to \a a and xmax set to vtkMath::Inf().
		/// When specifying Inf() or NegInf() for an endpoint, it does not matter whether
		/// you specify and open or closed endpoint.
		///
		/// When creating intervals, any integers can be used for the IDs of output meshes.
		/// All that matters is that the same ID be used if intervals should output to the same mesh.
		/// The outputs are ordered with ascending IDs in output block 0.
		///
		/// It is possible to specify an invalid interval, in which case these routines will return -1.
		/// Invalid intervals occur when
		/// - an array does not exist,
		/// - \a center is invalid,
		/// - \a xmin == \a xmax and \a omin and/or \a omax are vtkMultiThreshold::OPEN, or
		/// - \a xmin &gt; \a xmax.
		/// - \a xmin or \a xmax is not a number (i.e., IEEE NaN). Having both \a xmin and \a xmax equal
		///             NaN is allowed.
		/// vtkMath provides a portable way to specify IEEE infinities and Nan.
		/// Note that specifying an interval completely out of the bounds of an attribute is considered
		///             valid.
		/// In fact, it is occasionally useful to create a closed interval with both endpoints set to
		///             f$\infty\f$
		/// or both endpoints set to \f$-\infty\f$ in order to locate cells with problematic values.
		///
		/// @param xmin The minimum attribute value
		/// @param xmax The maximum attribute value
		/// @param omin Whether the interval should be open or closed at \a xmin. Use
		///             vtkMultiThreshold::OPEN or vtkMultiThreshold::CLOSED.
		/// @param omax Whether the interval should be open or closed at \a xmax. Use
		///             vtkMultiThreshold::OPEN or vtkMultiThreshold::CLOSED.
		/// @param assoc One of vtkDataObject::FIELD_ASSOCIATION_CELLS or
		///             vtkDataObject::FIELD_ASSOCIATION_POINTS indicating whether
		/// a point or cell array should be used.
		/// @param arrayName The name of the array to use for thresholding
		/// @param attribType The attribute to use for thresholding.
		/// One of vtkDataSetAttributes::SCALARS, VECTORS, TENSORS, NORMALS, TCOORDS, or GLOBALIDS.
		/// @param component The number of the component to threshold on or one of the following enumerants
		///             for norms:
		/// LINFINITY_NORM, L2_NORM, L1_NORM.
		/// @param allScalars When \a center is vtkDataObject::FIELD_ASSOCIATION_POINTS, must all scalars
		///             be in the interval for
		/// the cell to be passed to the output, or just a single point's scalar?
		/// @return An index used to identify the cells selected by the interval or -1 if the interval
		///             specification was invalid.
		/// If a valid value is returned, you may pass it to OutputSet().
		/// </summary>
		// Token: 0x06017333 RID: 95027 RVA: 0x00209178 File Offset: 0x00207378
		public int AddIntervalSet(double xmin, double xmax, int omin, int omax, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddIntervalSet_04(base.GetCppThis(), xmin, xmax, omin, omax, assoc, arrayName, component, allScalars);
		}

		// Token: 0x06017334 RID: 95028
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_AddIntervalSet_05(HandleRef pThis, double xmin, double xmax, int omin, int omax, int assoc, int attribType, int component, int allScalars);

		/// <summary>
		/// Add a mesh subset to be computed by thresholding an attribute of the input mesh.
		/// The subset can then be added to an output mesh with OutputSet() or
		/// combined with other sets using AddBooleanSet.
		/// If you wish to include all cells with values below some number \a a, call
		/// with xmin set to vtkMath::NegInf() and xmax set to \a a.
		/// Similarly, if you wish to include all cells with values above some number \a a,
		/// call with xmin set to \a a and xmax set to vtkMath::Inf().
		/// When specifying Inf() or NegInf() for an endpoint, it does not matter whether
		/// you specify and open or closed endpoint.
		///
		/// When creating intervals, any integers can be used for the IDs of output meshes.
		/// All that matters is that the same ID be used if intervals should output to the same mesh.
		/// The outputs are ordered with ascending IDs in output block 0.
		///
		/// It is possible to specify an invalid interval, in which case these routines will return -1.
		/// Invalid intervals occur when
		/// - an array does not exist,
		/// - \a center is invalid,
		/// - \a xmin == \a xmax and \a omin and/or \a omax are vtkMultiThreshold::OPEN, or
		/// - \a xmin &gt; \a xmax.
		/// - \a xmin or \a xmax is not a number (i.e., IEEE NaN). Having both \a xmin and \a xmax equal
		///             NaN is allowed.
		/// vtkMath provides a portable way to specify IEEE infinities and Nan.
		/// Note that specifying an interval completely out of the bounds of an attribute is considered
		///             valid.
		/// In fact, it is occasionally useful to create a closed interval with both endpoints set to
		///             f$\infty\f$
		/// or both endpoints set to \f$-\infty\f$ in order to locate cells with problematic values.
		///
		/// @param xmin The minimum attribute value
		/// @param xmax The maximum attribute value
		/// @param omin Whether the interval should be open or closed at \a xmin. Use
		///             vtkMultiThreshold::OPEN or vtkMultiThreshold::CLOSED.
		/// @param omax Whether the interval should be open or closed at \a xmax. Use
		///             vtkMultiThreshold::OPEN or vtkMultiThreshold::CLOSED.
		/// @param assoc One of vtkDataObject::FIELD_ASSOCIATION_CELLS or
		///             vtkDataObject::FIELD_ASSOCIATION_POINTS indicating whether
		/// a point or cell array should be used.
		/// @param arrayName The name of the array to use for thresholding
		/// @param attribType The attribute to use for thresholding.
		/// One of vtkDataSetAttributes::SCALARS, VECTORS, TENSORS, NORMALS, TCOORDS, or GLOBALIDS.
		/// @param component The number of the component to threshold on or one of the following enumerants
		///             for norms:
		/// LINFINITY_NORM, L2_NORM, L1_NORM.
		/// @param allScalars When \a center is vtkDataObject::FIELD_ASSOCIATION_POINTS, must all scalars
		///             be in the interval for
		/// the cell to be passed to the output, or just a single point's scalar?
		/// @return An index used to identify the cells selected by the interval or -1 if the interval
		///             specification was invalid.
		/// If a valid value is returned, you may pass it to OutputSet().
		/// </summary>
		// Token: 0x06017335 RID: 95029 RVA: 0x002091A4 File Offset: 0x002073A4
		public int AddIntervalSet(double xmin, double xmax, int omin, int omax, int assoc, int attribType, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddIntervalSet_05(base.GetCppThis(), xmin, xmax, omin, omax, assoc, attribType, component, allScalars);
		}

		// Token: 0x06017336 RID: 95030
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_AddLowpassIntervalSet_06(HandleRef pThis, double xmax, int assoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component, int allScalars);

		/// <summary>
		/// These convenience members make it easy to insert closed intervals.
		/// The "notch" interval is accomplished by creating a bandpass interval and applying a NAND
		/// operation. In this case, the set ID returned in the NAND operation set ID. Note that you can
		/// pass xmin == xmax when creating a bandpass threshold to retrieve elements matching exactly one
		/// value (since the intervals created by these routines are closed).
		/// </summary>
		// Token: 0x06017337 RID: 95031 RVA: 0x002091D0 File Offset: 0x002073D0
		public int AddLowpassIntervalSet(double xmax, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddLowpassIntervalSet_06(base.GetCppThis(), xmax, assoc, arrayName, component, allScalars);
		}

		// Token: 0x06017338 RID: 95032
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_AddNotchIntervalSet_07(HandleRef pThis, double xlo, double xhi, int assoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component, int allScalars);

		/// <summary>
		/// These convenience members make it easy to insert closed intervals.
		/// The "notch" interval is accomplished by creating a bandpass interval and applying a NAND
		/// operation. In this case, the set ID returned in the NAND operation set ID. Note that you can
		/// pass xmin == xmax when creating a bandpass threshold to retrieve elements matching exactly one
		/// value (since the intervals created by these routines are closed).
		/// </summary>
		// Token: 0x06017339 RID: 95033 RVA: 0x002091F8 File Offset: 0x002073F8
		public int AddNotchIntervalSet(double xlo, double xhi, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddNotchIntervalSet_07(base.GetCppThis(), xlo, xhi, assoc, arrayName, component, allScalars);
		}

		// Token: 0x0601733A RID: 95034
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiThreshold_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601733B RID: 95035 RVA: 0x00209220 File Offset: 0x00207420
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiThreshold.vtkMultiThreshold_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601733C RID: 95036
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiThreshold_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601733D RID: 95037 RVA: 0x00209240 File Offset: 0x00207440
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiThreshold.vtkMultiThreshold_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601733E RID: 95038
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601733F RID: 95039 RVA: 0x0020925C File Offset: 0x0020745C
		public override int IsA(string type)
		{
			return vtkMultiThreshold.vtkMultiThreshold_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06017340 RID: 95040
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017341 RID: 95041 RVA: 0x0020927C File Offset: 0x0020747C
		public new static int IsTypeOf(string type)
		{
			return vtkMultiThreshold.vtkMultiThreshold_IsTypeOf_11(type);
		}

		// Token: 0x06017342 RID: 95042
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiThreshold_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017343 RID: 95043 RVA: 0x00209298 File Offset: 0x00207498
		public new vtkMultiThreshold NewInstance()
		{
			vtkMultiThreshold result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiThreshold.vtkMultiThreshold_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017344 RID: 95044
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreshold_OutputSet_14(HandleRef pThis, int setId);

		/// <summary>
		/// Create an output mesh containing a boolean or interval subset of the input mesh.
		/// </summary>
		// Token: 0x06017345 RID: 95045 RVA: 0x002092F4 File Offset: 0x002074F4
		public int OutputSet(int setId)
		{
			return vtkMultiThreshold.vtkMultiThreshold_OutputSet_14(base.GetCppThis(), setId);
		}

		// Token: 0x06017346 RID: 95046
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiThreshold_Reset_15(HandleRef pThis);

		/// <summary>
		/// Remove all the intervals currently defined.
		/// </summary>
		// Token: 0x06017347 RID: 95047 RVA: 0x00209314 File Offset: 0x00207514
		public void Reset()
		{
			vtkMultiThreshold.vtkMultiThreshold_Reset_15(base.GetCppThis());
		}

		// Token: 0x06017348 RID: 95048
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiThreshold_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017349 RID: 95049 RVA: 0x00209324 File Offset: 0x00207524
		public new static vtkMultiThreshold SafeDownCast(vtkObjectBase o)
		{
			vtkMultiThreshold vtkMultiThreshold = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiThreshold.vtkMultiThreshold_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiThreshold = (vtkMultiThreshold)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiThreshold.Register(null);
				}
			}
			return vtkMultiThreshold;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019EC RID: 6636
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiThreshold";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019ED RID: 6637
		public new static readonly string MRClassNameKey = "class vtkMultiThreshold";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020008C0 RID: 2240
		public enum Closure
		{
			/// <summary>enum member</summary>
			// Token: 0x040019EF RID: 6639
			CLOSED = 1,
			/// <summary>enum member</summary>
			// Token: 0x040019F0 RID: 6640
			OPEN = 0
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020008C1 RID: 2241
		public enum Norm
		{
			/// <summary>enum member</summary>
			// Token: 0x040019F2 RID: 6642
			L1_NORM = -1,
			/// <summary>enum member</summary>
			// Token: 0x040019F3 RID: 6643
			L2_NORM = -2,
			/// <summary>enum member</summary>
			// Token: 0x040019F4 RID: 6644
			LINFINITY_NORM = -3
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020008C2 RID: 2242
		public enum SetOperation
		{
			/// <summary>enum member</summary>
			// Token: 0x040019F6 RID: 6646
			AND,
			/// <summary>enum member</summary>
			// Token: 0x040019F7 RID: 6647
			NAND = 4,
			/// <summary>enum member</summary>
			// Token: 0x040019F8 RID: 6648
			OR = 1,
			/// <summary>enum member</summary>
			// Token: 0x040019F9 RID: 6649
			WOR = 3,
			/// <summary>enum member</summary>
			// Token: 0x040019FA RID: 6650
			XOR = 2
		}

		/// <summary>
		/// Remove all the intervals currently defined.
		/// </summary>
		// Token: 0x020008C3 RID: 2243
		// (Invoke) Token: 0x0601734B RID: 95051
		public delegate double TupleNorm(IntPtr arg0, long arg1, int arg2);
	}
}
