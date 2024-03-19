using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetAttributes
	/// </summary>
	/// <remarks>
	///    represent and manipulate attribute data in a dataset
	///
	/// vtkDataSetAttributes is a class that is used to represent and manipulate
	/// attribute data (e.g., scalars, vectors, normals, texture coordinates,
	/// tensors, global ids, pedigree ids, and field data).
	///
	/// This adds to vtkFieldData the ability to pick one of the arrays from the
	/// field as the currently active array for each attribute type. In other
	/// words, you pick one array to be called "THE" Scalars, and then filters down
	/// the pipeline will treat that array specially. For example vtkContourFilter
	/// will contour "THE" Scalar array unless a different array is asked for.
	///
	/// Additionally vtkDataSetAttributes provides methods that filters call to
	/// pass data through, copy data into, and interpolate from Fields. PassData
	/// passes entire arrays from the source to the destination. Copy passes
	/// through some subset of the tuples from the source to the destination.
	/// Interpolate interpolates from the chosen tuple(s) in the source data, using
	/// the provided weights, to produce new tuples in the destination.
	/// Each attribute type has pass, copy and interpolate "copy" flags that
	/// can be set in the destination to choose which attribute arrays will be
	/// transferred from the source to the destination.
	///
	/// Finally this class provides a mechanism to determine which attributes a
	/// group of sources have in common, and to copy tuples from a source into
	/// the destination, for only those attributes that are held by all.
	///
	/// @warning
	/// vtkDataSetAttributes is not in general thread safe due to the use of its
	/// vtkFieldData::BasicIterator RequiredArrays data member. The class
	/// vtkArrayListTemplate augments vtkDataSetAttributes for thread safety.
	///
	/// </remarks>
	/// <seealso>
	///  vtkArrayListTemplate
	/// </seealso>
	// Token: 0x02000A17 RID: 2583
	public class vtkDataSetAttributes : vtkFieldData
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AED0 RID: 110288 RVA: 0x00258812 File Offset: 0x00256A12
		static vtkDataSetAttributes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetAttributes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AED1 RID: 110289 RVA: 0x0025883A File Offset: 0x00256A3A
		public vtkDataSetAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AED2 RID: 110290
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with copying turned on for all data.
		/// </summary>
		// Token: 0x0601AED3 RID: 110291 RVA: 0x00258848 File Offset: 0x00256A48
		public new static vtkDataSetAttributes New()
		{
			vtkDataSetAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with copying turned on for all data.
		/// </summary>
		// Token: 0x0601AED4 RID: 110292 RVA: 0x0025889C File Offset: 0x00256A9C
		public vtkDataSetAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetAttributes.vtkDataSetAttributes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AED5 RID: 110293 RVA: 0x002588E0 File Offset: 0x00256AE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AED6 RID: 110294
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyAllOff_01(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AED7 RID: 110295 RVA: 0x002588EB File Offset: 0x00256AEB
		public override void CopyAllOff(int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyAllOff_01(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AED8 RID: 110296
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyAllOn_02(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AED9 RID: 110297 RVA: 0x002588FB File Offset: 0x00256AFB
		public override void CopyAllOn(int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyAllOn_02(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AEDA RID: 110298
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyAllocate_03(HandleRef pThis, HandleRef pd, long sze, long ext);

		/// <summary>
		/// Allocates point data for point-by-point (or cell-by-cell) copy operation.
		/// If sze=0, then use the input DataSetAttributes to create (i.e., find
		/// initial size of) new objects; otherwise use the sze variable.
		/// Note that pd HAS to be the vtkDataSetAttributes object which
		/// will later be used with CopyData. If this is not the case,
		/// consider using the alternative forms of CopyAllocate and CopyData.
		/// ext is no longer used.
		/// If shallowCopyArrays is true, input arrays are copied to the output
		/// instead of new ones being allocated.
		/// </summary>
		// Token: 0x0601AEDB RID: 110299 RVA: 0x0025890C File Offset: 0x00256B0C
		public void CopyAllocate(vtkDataSetAttributes pd, long sze, long ext)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyAllocate_03(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), sze, ext);
		}

		// Token: 0x0601AEDC RID: 110300
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyAllocate_04(HandleRef pThis, HandleRef pd, long sze, long ext, int shallowCopyArrays);

		/// <summary>
		/// Allocates point data for point-by-point (or cell-by-cell) copy operation.
		/// If sze=0, then use the input DataSetAttributes to create (i.e., find
		/// initial size of) new objects; otherwise use the sze variable.
		/// Note that pd HAS to be the vtkDataSetAttributes object which
		/// will later be used with CopyData. If this is not the case,
		/// consider using the alternative forms of CopyAllocate and CopyData.
		/// ext is no longer used.
		/// If shallowCopyArrays is true, input arrays are copied to the output
		/// instead of new ones being allocated.
		/// </summary>
		// Token: 0x0601AEDD RID: 110301 RVA: 0x00258940 File Offset: 0x00256B40
		public void CopyAllocate(vtkDataSetAttributes pd, long sze, long ext, int shallowCopyArrays)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyAllocate_04(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), sze, ext, shallowCopyArrays);
		}

		// Token: 0x0601AEDE RID: 110302
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyAllocate_05(HandleRef pThis, vtkDataSetAttributesFieldList list, long sze, long ext);

		/// <summary>
		/// A special form of CopyAllocate() to be used with FieldLists. Use it
		/// when you are copying data from a set of vtkDataSetAttributes.
		/// </summary>
		// Token: 0x0601AEDF RID: 110303 RVA: 0x00258973 File Offset: 0x00256B73
		public void CopyAllocate(vtkDataSetAttributesFieldList list, long sze, long ext)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyAllocate_05(base.GetCppThis(), list, sze, ext);
		}

		// Token: 0x0601AEE0 RID: 110304
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyData_06(HandleRef pThis, HandleRef fromPd, long fromId, long toId);

		/// <summary>
		/// Copy the attribute data from one id to another. Make sure CopyAllocate()
		/// has been invoked before using this method. When copying a field,
		/// the following copying rules are
		/// followed: 1) Check if a field is an attribute, if yes and if there
		/// is a COPYTUPLE copy flag for that attribute (on or off), obey the flag
		/// for that attribute, ignore (2) and (3), 2) if there is a copy field for
		/// that field (on or off), obey the flag, ignore (3) 3) obey
		/// CopyAllOn/Off
		///
		/// @warning This method is prone to compile-time ambiguity when called using `0` parameters.
		/// To fix the ambiguity, please replace `0` by `vtkIdType(0)`.
		/// </summary>
		// Token: 0x0601AEE1 RID: 110305 RVA: 0x00258988 File Offset: 0x00256B88
		public void CopyData(vtkDataSetAttributes fromPd, long fromId, long toId)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyData_06(base.GetCppThis(), (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), fromId, toId);
		}

		// Token: 0x0601AEE2 RID: 110306
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyData_07(HandleRef pThis, HandleRef fromPd, HandleRef fromIds, HandleRef toIds);

		/// <summary>
		/// Copy the attribute data from one id to another. Make sure CopyAllocate()
		/// has been invoked before using this method. When copying a field,
		/// the following copying rules are
		/// followed: 1) Check if a field is an attribute, if yes and if there
		/// is a COPYTUPLE copy flag for that attribute (on or off), obey the flag
		/// for that attribute, ignore (2) and (3), 2) if there is a copy field for
		/// that field (on or off), obey the flag, ignore (3) 3) obey
		/// CopyAllOn/Off
		///
		/// @warning This method is prone to compile-time ambiguity when called using `0` parameters.
		/// To fix the ambiguity, please replace `0` by `vtkIdType(0)`.
		/// </summary>
		// Token: 0x0601AEE3 RID: 110307 RVA: 0x002589BC File Offset: 0x00256BBC
		public void CopyData(vtkDataSetAttributes fromPd, vtkIdList fromIds, vtkIdList toIds)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyData_07(base.GetCppThis(), (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), (fromIds == null) ? default(HandleRef) : fromIds.GetCppThis(), (toIds == null) ? default(HandleRef) : toIds.GetCppThis());
		}

		// Token: 0x0601AEE4 RID: 110308
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyData_08(HandleRef pThis, HandleRef fromPd, HandleRef fromIds, long destStartId);

		/// <summary>
		/// Copy the attribute data from one id to another. Make sure CopyAllocate()
		/// has been invoked before using this method. When copying a field,
		/// the following copying rules are
		/// followed: 1) Check if a field is an attribute, if yes and if there
		/// is a COPYTUPLE copy flag for that attribute (on or off), obey the flag
		/// for that attribute, ignore (2) and (3), 2) if there is a copy field for
		/// that field (on or off), obey the flag, ignore (3) 3) obey
		/// CopyAllOn/Off
		///
		/// @warning This method is prone to compile-time ambiguity when called using `0` parameters.
		/// To fix the ambiguity, please replace `0` by `vtkIdType(0)`.
		/// </summary>
		// Token: 0x0601AEE5 RID: 110309 RVA: 0x00258A18 File Offset: 0x00256C18
		public void CopyData(vtkDataSetAttributes fromPd, vtkIdList fromIds, long destStartId)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyData_08(base.GetCppThis(), (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), (fromIds == null) ? default(HandleRef) : fromIds.GetCppThis(), destStartId);
		}

		// Token: 0x0601AEE6 RID: 110310
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyData_09(HandleRef pThis, HandleRef fromPd, long dstStart, long n, long srcStart);

		/// <summary>
		/// Copy n consecutive attributes starting at srcStart from fromPd to this
		/// container, starting at the dstStart location.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601AEE7 RID: 110311 RVA: 0x00258A60 File Offset: 0x00256C60
		public void CopyData(vtkDataSetAttributes fromPd, long dstStart, long n, long srcStart)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyData_09(base.GetCppThis(), (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), dstStart, n, srcStart);
		}

		// Token: 0x0601AEE8 RID: 110312
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyData_10(HandleRef pThis, vtkDataSetAttributesFieldList list, HandleRef dsa, int idx, long fromId, long toId);

		/// <summary>
		/// Special forms of CopyData() to be used with FieldLists. Use it when
		/// you are copying data from a set of vtkDataSetAttributes. Make sure
		/// that you have called the special form of CopyAllocate that accepts
		/// FieldLists.
		/// </summary>
		// Token: 0x0601AEE9 RID: 110313 RVA: 0x00258A94 File Offset: 0x00256C94
		public void CopyData(vtkDataSetAttributesFieldList list, vtkDataSetAttributes dsa, int idx, long fromId, long toId)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyData_10(base.GetCppThis(), list, (dsa == null) ? default(HandleRef) : dsa.GetCppThis(), idx, fromId, toId);
		}

		// Token: 0x0601AEEA RID: 110314
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyData_11(HandleRef pThis, vtkDataSetAttributesFieldList list, HandleRef dsa, int idx, long dstStart, long n, long srcStart);

		/// <summary>
		/// Special forms of CopyData() to be used with FieldLists. Use it when
		/// you are copying data from a set of vtkDataSetAttributes. Make sure
		/// that you have called the special form of CopyAllocate that accepts
		/// FieldLists.
		/// </summary>
		// Token: 0x0601AEEB RID: 110315 RVA: 0x00258ACC File Offset: 0x00256CCC
		public void CopyData(vtkDataSetAttributesFieldList list, vtkDataSetAttributes dsa, int idx, long dstStart, long n, long srcStart)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyData_11(base.GetCppThis(), list, (dsa == null) ? default(HandleRef) : dsa.GetCppThis(), idx, dstStart, n, srcStart);
		}

		// Token: 0x0601AEEC RID: 110316
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyGlobalIdsOff_12(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEED RID: 110317 RVA: 0x00258B03 File Offset: 0x00256D03
		public virtual void CopyGlobalIdsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyGlobalIdsOff_12(base.GetCppThis());
		}

		// Token: 0x0601AEEE RID: 110318
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyGlobalIdsOn_13(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEEF RID: 110319 RVA: 0x00258B12 File Offset: 0x00256D12
		public virtual void CopyGlobalIdsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyGlobalIdsOn_13(base.GetCppThis());
		}

		// Token: 0x0601AEF0 RID: 110320
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyHigherOrderDegreesOff_14(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEF1 RID: 110321 RVA: 0x00258B21 File Offset: 0x00256D21
		public virtual void CopyHigherOrderDegreesOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyHigherOrderDegreesOff_14(base.GetCppThis());
		}

		// Token: 0x0601AEF2 RID: 110322
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyHigherOrderDegreesOn_15(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEF3 RID: 110323 RVA: 0x00258B30 File Offset: 0x00256D30
		public virtual void CopyHigherOrderDegreesOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyHigherOrderDegreesOn_15(base.GetCppThis());
		}

		// Token: 0x0601AEF4 RID: 110324
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyNormalsOff_16(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEF5 RID: 110325 RVA: 0x00258B3F File Offset: 0x00256D3F
		public virtual void CopyNormalsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyNormalsOff_16(base.GetCppThis());
		}

		// Token: 0x0601AEF6 RID: 110326
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyNormalsOn_17(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEF7 RID: 110327 RVA: 0x00258B4E File Offset: 0x00256D4E
		public virtual void CopyNormalsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyNormalsOn_17(base.GetCppThis());
		}

		// Token: 0x0601AEF8 RID: 110328
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyPedigreeIdsOff_18(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEF9 RID: 110329 RVA: 0x00258B5D File Offset: 0x00256D5D
		public virtual void CopyPedigreeIdsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyPedigreeIdsOff_18(base.GetCppThis());
		}

		// Token: 0x0601AEFA RID: 110330
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyPedigreeIdsOn_19(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEFB RID: 110331 RVA: 0x00258B6C File Offset: 0x00256D6C
		public virtual void CopyPedigreeIdsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyPedigreeIdsOn_19(base.GetCppThis());
		}

		// Token: 0x0601AEFC RID: 110332
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyProcessIdsOff_20(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEFD RID: 110333 RVA: 0x00258B7B File Offset: 0x00256D7B
		public virtual void CopyProcessIdsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyProcessIdsOff_20(base.GetCppThis());
		}

		// Token: 0x0601AEFE RID: 110334
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyProcessIdsOn_21(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AEFF RID: 110335 RVA: 0x00258B8A File Offset: 0x00256D8A
		public virtual void CopyProcessIdsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyProcessIdsOn_21(base.GetCppThis());
		}

		// Token: 0x0601AF00 RID: 110336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyRationalWeightsOff_22(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF01 RID: 110337 RVA: 0x00258B99 File Offset: 0x00256D99
		public virtual void CopyRationalWeightsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyRationalWeightsOff_22(base.GetCppThis());
		}

		// Token: 0x0601AF02 RID: 110338
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyRationalWeightsOn_23(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF03 RID: 110339 RVA: 0x00258BA8 File Offset: 0x00256DA8
		public virtual void CopyRationalWeightsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyRationalWeightsOn_23(base.GetCppThis());
		}

		// Token: 0x0601AF04 RID: 110340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyScalarsOff_24(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF05 RID: 110341 RVA: 0x00258BB7 File Offset: 0x00256DB7
		public virtual void CopyScalarsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyScalarsOff_24(base.GetCppThis());
		}

		// Token: 0x0601AF06 RID: 110342
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyScalarsOn_25(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF07 RID: 110343 RVA: 0x00258BC6 File Offset: 0x00256DC6
		public virtual void CopyScalarsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyScalarsOn_25(base.GetCppThis());
		}

		// Token: 0x0601AF08 RID: 110344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyStructuredData_26(HandleRef pThis, HandleRef inDsa, IntPtr inExt, IntPtr outExt, byte setSize);

		/// <summary>
		/// This method is used to copy data arrays in images.
		/// You should call CopyAllocate or SetupForCopy before
		/// calling this method. If setSize is true, this method
		/// will set the size of the output arrays according to
		/// the output extent. This is required when CopyAllocate()
		/// was used to setup output arrays.
		/// </summary>
		// Token: 0x0601AF09 RID: 110345 RVA: 0x00258BD8 File Offset: 0x00256DD8
		public void CopyStructuredData(vtkDataSetAttributes inDsa, IntPtr inExt, IntPtr outExt, bool setSize)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyStructuredData_26(base.GetCppThis(), (inDsa == null) ? default(HandleRef) : inDsa.GetCppThis(), inExt, outExt, setSize ? (byte)1 : (byte)0);
		}

		// Token: 0x0601AF0A RID: 110346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyTCoordsOff_27(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF0B RID: 110347 RVA: 0x00258C13 File Offset: 0x00256E13
		public virtual void CopyTCoordsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTCoordsOff_27(base.GetCppThis());
		}

		// Token: 0x0601AF0C RID: 110348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyTCoordsOn_28(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF0D RID: 110349 RVA: 0x00258C22 File Offset: 0x00256E22
		public virtual void CopyTCoordsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTCoordsOn_28(base.GetCppThis());
		}

		// Token: 0x0601AF0E RID: 110350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyTangentsOff_29(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF0F RID: 110351 RVA: 0x00258C31 File Offset: 0x00256E31
		public virtual void CopyTangentsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTangentsOff_29(base.GetCppThis());
		}

		// Token: 0x0601AF10 RID: 110352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyTangentsOn_30(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF11 RID: 110353 RVA: 0x00258C40 File Offset: 0x00256E40
		public virtual void CopyTangentsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTangentsOn_30(base.GetCppThis());
		}

		// Token: 0x0601AF12 RID: 110354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyTensorsOff_31(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF13 RID: 110355 RVA: 0x00258C4F File Offset: 0x00256E4F
		public virtual void CopyTensorsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTensorsOff_31(base.GetCppThis());
		}

		// Token: 0x0601AF14 RID: 110356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyTensorsOn_32(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF15 RID: 110357 RVA: 0x00258C5E File Offset: 0x00256E5E
		public virtual void CopyTensorsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTensorsOn_32(base.GetCppThis());
		}

		// Token: 0x0601AF16 RID: 110358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyTuple_33(HandleRef pThis, HandleRef fromData, HandleRef toData, long fromId, long toId);

		/// <summary>
		/// Copy a tuple (or set of tuples) of data from one data array to another.
		/// This method assumes that the fromData and toData objects are of the
		/// same type, and have the same number of components. This is true if you
		/// invoke CopyAllocate() or InterpolateAllocate().
		/// </summary>
		// Token: 0x0601AF17 RID: 110359 RVA: 0x00258C70 File Offset: 0x00256E70
		public void CopyTuple(vtkAbstractArray fromData, vtkAbstractArray toData, long fromId, long toId)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTuple_33(base.GetCppThis(), (fromData == null) ? default(HandleRef) : fromData.GetCppThis(), (toData == null) ? default(HandleRef) : toData.GetCppThis(), fromId, toId);
		}

		// Token: 0x0601AF18 RID: 110360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyTuples_34(HandleRef pThis, HandleRef fromData, HandleRef toData, HandleRef fromIds, HandleRef toIds);

		/// <summary>
		/// Copy a tuple (or set of tuples) of data from one data array to another.
		/// This method assumes that the fromData and toData objects are of the
		/// same type, and have the same number of components. This is true if you
		/// invoke CopyAllocate() or InterpolateAllocate().
		/// </summary>
		// Token: 0x0601AF19 RID: 110361 RVA: 0x00258CB8 File Offset: 0x00256EB8
		public void CopyTuples(vtkAbstractArray fromData, vtkAbstractArray toData, vtkIdList fromIds, vtkIdList toIds)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTuples_34(base.GetCppThis(), (fromData == null) ? default(HandleRef) : fromData.GetCppThis(), (toData == null) ? default(HandleRef) : toData.GetCppThis(), (fromIds == null) ? default(HandleRef) : fromIds.GetCppThis(), (toIds == null) ? default(HandleRef) : toIds.GetCppThis());
		}

		// Token: 0x0601AF1A RID: 110362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyTuples_35(HandleRef pThis, HandleRef fromData, HandleRef toData, long dstStart, long n, long srcStart);

		/// <summary>
		/// Copy a tuple (or set of tuples) of data from one data array to another.
		/// This method assumes that the fromData and toData objects are of the
		/// same type, and have the same number of components. This is true if you
		/// invoke CopyAllocate() or InterpolateAllocate().
		/// </summary>
		// Token: 0x0601AF1B RID: 110363 RVA: 0x00258D28 File Offset: 0x00256F28
		public void CopyTuples(vtkAbstractArray fromData, vtkAbstractArray toData, long dstStart, long n, long srcStart)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTuples_35(base.GetCppThis(), (fromData == null) ? default(HandleRef) : fromData.GetCppThis(), (toData == null) ? default(HandleRef) : toData.GetCppThis(), dstStart, n, srcStart);
		}

		// Token: 0x0601AF1C RID: 110364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyVectorsOff_36(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF1D RID: 110365 RVA: 0x00258D71 File Offset: 0x00256F71
		public virtual void CopyVectorsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyVectorsOff_36(base.GetCppThis());
		}

		// Token: 0x0601AF1E RID: 110366
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_CopyVectorsOn_37(HandleRef pThis);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF1F RID: 110367 RVA: 0x00258D80 File Offset: 0x00256F80
		public virtual void CopyVectorsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyVectorsOn_37(base.GetCppThis());
		}

		// Token: 0x0601AF20 RID: 110368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_DeepCopy_38(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Deep copy of data (i.e., create new data arrays and
		/// copy from input data).
		/// Ignores the copy flags but preserves them in the output.
		/// </summary>
		// Token: 0x0601AF21 RID: 110369 RVA: 0x00258D90 File Offset: 0x00256F90
		public override void DeepCopy(vtkFieldData pd)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_DeepCopy_38(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601AF22 RID: 110370
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_ExtendedNew_39(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with copying turned on for all data.
		/// </summary>
		// Token: 0x0601AF23 RID: 110371 RVA: 0x00258DC0 File Offset: 0x00256FC0
		public new static vtkDataSetAttributes ExtendedNew()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_ExtendedNew_39(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601AF24 RID: 110372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetAbstractAttribute_40(HandleRef pThis, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an attribute given the attribute type
		/// (see vtkDataSetAttributes::AttributeTypes).
		/// This is the same as GetAttribute(), except that the returned array
		/// is a vtkAbstractArray instead of vtkDataArray.
		/// Some attributes (such as PEDIGREEIDS) may not be vtkDataArray subclass.
		/// </summary>
		// Token: 0x0601AF25 RID: 110373 RVA: 0x00258E2C File Offset: 0x0025702C
		public vtkAbstractArray GetAbstractAttribute(int attributeType)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetAbstractAttribute_40(base.GetCppThis(), attributeType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601AF26 RID: 110374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetAttribute_41(HandleRef pThis, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an attribute given the attribute type
		/// (see vtkDataSetAttributes::AttributeTypes).
		/// Some attributes (such as PEDIGREEIDS) may not be vtkDataArray subclass,
		/// so in that case use GetAbstractAttribute().
		/// </summary>
		// Token: 0x0601AF27 RID: 110375 RVA: 0x00258E9C File Offset: 0x0025709C
		public vtkDataArray GetAttribute(int attributeType)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetAttribute_41(base.GetCppThis(), attributeType, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF28 RID: 110376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_GetAttributeIndices_42(HandleRef pThis, IntPtr indexArray);

		/// <summary>
		/// Get the field data array indices corresponding to scalars,
		/// vectors, tensors, etc.  The given buffer must be at least
		/// NUM_ATTRIBUTES elements big.
		/// </summary>
		// Token: 0x0601AF29 RID: 110377 RVA: 0x00258F0C File Offset: 0x0025710C
		public void GetAttributeIndices(IntPtr indexArray)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_GetAttributeIndices_42(base.GetCppThis(), indexArray);
		}

		// Token: 0x0601AF2A RID: 110378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetAttributeTypeAsString_43(int attributeType);

		/// <summary>
		/// Given an integer attribute type, this static method returns a string type
		/// for the attribute (i.e. type = 0: returns "Scalars").
		/// </summary>
		// Token: 0x0601AF2B RID: 110379 RVA: 0x00258F1C File Offset: 0x0025711C
		public static string GetAttributeTypeAsString(int attributeType)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetAttributes.vtkDataSetAttributes_GetAttributeTypeAsString_43(attributeType));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601AF2C RID: 110380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyAttribute_44(HandleRef pThis, int index, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF2D RID: 110381 RVA: 0x00258F54 File Offset: 0x00257154
		public int GetCopyAttribute(int index, int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyAttribute_44(base.GetCppThis(), index, ctype);
		}

		// Token: 0x0601AF2E RID: 110382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyGlobalIds_45(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF2F RID: 110383 RVA: 0x00258F78 File Offset: 0x00257178
		public int GetCopyGlobalIds(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyGlobalIds_45(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF30 RID: 110384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyHigherOrderDegrees_46(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF31 RID: 110385 RVA: 0x00258F98 File Offset: 0x00257198
		public int GetCopyHigherOrderDegrees(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyHigherOrderDegrees_46(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF32 RID: 110386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyNormals_47(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF33 RID: 110387 RVA: 0x00258FB8 File Offset: 0x002571B8
		public int GetCopyNormals(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyNormals_47(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF34 RID: 110388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyPedigreeIds_48(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF35 RID: 110389 RVA: 0x00258FD8 File Offset: 0x002571D8
		public int GetCopyPedigreeIds(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyPedigreeIds_48(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF36 RID: 110390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyProcessIds_49(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF37 RID: 110391 RVA: 0x00258FF8 File Offset: 0x002571F8
		public int GetCopyProcessIds(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyProcessIds_49(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF38 RID: 110392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyRationalWeights_50(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF39 RID: 110393 RVA: 0x00259018 File Offset: 0x00257218
		public int GetCopyRationalWeights(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyRationalWeights_50(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF3A RID: 110394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyScalars_51(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF3B RID: 110395 RVA: 0x00259038 File Offset: 0x00257238
		public int GetCopyScalars(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyScalars_51(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF3C RID: 110396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyTCoords_52(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF3D RID: 110397 RVA: 0x00259058 File Offset: 0x00257258
		public int GetCopyTCoords(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyTCoords_52(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF3E RID: 110398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyTangents_53(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF3F RID: 110399 RVA: 0x00259078 File Offset: 0x00257278
		public int GetCopyTangents(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyTangents_53(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF40 RID: 110400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyTensors_54(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF41 RID: 110401 RVA: 0x00259098 File Offset: 0x00257298
		public int GetCopyTensors(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyTensors_54(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF42 RID: 110402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_GetCopyVectors_55(HandleRef pThis, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AF43 RID: 110403 RVA: 0x002590B8 File Offset: 0x002572B8
		public int GetCopyVectors(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyVectors_55(base.GetCppThis(), ctype);
		}

		// Token: 0x0601AF44 RID: 110404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetGlobalIds_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the global id data.
		/// </summary>
		// Token: 0x0601AF45 RID: 110405 RVA: 0x002590D8 File Offset: 0x002572D8
		public vtkDataArray GetGlobalIds()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetGlobalIds_56(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF46 RID: 110406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetGlobalIds_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF47 RID: 110407 RVA: 0x00259148 File Offset: 0x00257348
		public vtkDataArray GetGlobalIds(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetGlobalIds_57(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF48 RID: 110408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetHigherOrderDegrees_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the rational degrees data.
		/// </summary>
		// Token: 0x0601AF49 RID: 110409 RVA: 0x002591B8 File Offset: 0x002573B8
		public vtkDataArray GetHigherOrderDegrees()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetHigherOrderDegrees_58(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF4A RID: 110410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetHigherOrderDegrees_59(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF4B RID: 110411 RVA: 0x00259228 File Offset: 0x00257428
		public vtkDataArray GetHigherOrderDegrees(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetHigherOrderDegrees_59(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF4C RID: 110412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetLongAttributeTypeAsString_60(int attributeType);

		/// <summary>
		/// Given an integer attribute type, this static method returns a string type
		/// for the attribute (i.e. type = 0: returns "Scalars").
		/// </summary>
		// Token: 0x0601AF4D RID: 110413 RVA: 0x00259298 File Offset: 0x00257498
		public static string GetLongAttributeTypeAsString(int attributeType)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetAttributes.vtkDataSetAttributes_GetLongAttributeTypeAsString_60(attributeType));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601AF4E RID: 110414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetNormals_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the normal data.
		/// </summary>
		// Token: 0x0601AF4F RID: 110415 RVA: 0x002592D0 File Offset: 0x002574D0
		public vtkDataArray GetNormals()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetNormals_61(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF50 RID: 110416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetNormals_62(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF51 RID: 110417 RVA: 0x00259340 File Offset: 0x00257540
		public vtkDataArray GetNormals(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetNormals_62(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF52 RID: 110418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetAttributes_GetNumberOfGenerationsFromBase_63(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with copying turned on for all data.
		/// </summary>
		// Token: 0x0601AF53 RID: 110419 RVA: 0x002593B0 File Offset: 0x002575B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetNumberOfGenerationsFromBase_63(base.GetCppThis(), type);
		}

		// Token: 0x0601AF54 RID: 110420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetAttributes_GetNumberOfGenerationsFromBaseType_64([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with copying turned on for all data.
		/// </summary>
		// Token: 0x0601AF55 RID: 110421 RVA: 0x002593D0 File Offset: 0x002575D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetNumberOfGenerationsFromBaseType_64(type);
		}

		// Token: 0x0601AF56 RID: 110422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetPedigreeIds_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the pedigree id data.
		/// </summary>
		// Token: 0x0601AF57 RID: 110423 RVA: 0x002593EC File Offset: 0x002575EC
		public vtkAbstractArray GetPedigreeIds()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetPedigreeIds_65(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601AF58 RID: 110424
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetPedigreeIds_66(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF59 RID: 110425 RVA: 0x0025945C File Offset: 0x0025765C
		public vtkAbstractArray GetPedigreeIds(string name)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetPedigreeIds_66(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601AF5A RID: 110426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetProcessIds_67(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the process id data.
		/// </summary>
		// Token: 0x0601AF5B RID: 110427 RVA: 0x002594CC File Offset: 0x002576CC
		public vtkDataArray GetProcessIds()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetProcessIds_67(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF5C RID: 110428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetProcessIds_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF5D RID: 110429 RVA: 0x0025953C File Offset: 0x0025773C
		public vtkDataArray GetProcessIds(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetProcessIds_68(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF5E RID: 110430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetRationalWeights_69(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the rational weights data.
		/// </summary>
		// Token: 0x0601AF5F RID: 110431 RVA: 0x002595AC File Offset: 0x002577AC
		public vtkDataArray GetRationalWeights()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetRationalWeights_69(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF60 RID: 110432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetRationalWeights_70(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF61 RID: 110433 RVA: 0x0025961C File Offset: 0x0025781C
		public vtkDataArray GetRationalWeights(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetRationalWeights_70(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF62 RID: 110434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetScalars_71(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the scalar data.
		/// </summary>
		// Token: 0x0601AF63 RID: 110435 RVA: 0x0025968C File Offset: 0x0025788C
		public vtkDataArray GetScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetScalars_71(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF64 RID: 110436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetScalars_72(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF65 RID: 110437 RVA: 0x002596FC File Offset: 0x002578FC
		public vtkDataArray GetScalars(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetScalars_72(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF66 RID: 110438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetTCoords_73(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the texture coordinate data.
		/// </summary>
		// Token: 0x0601AF67 RID: 110439 RVA: 0x0025976C File Offset: 0x0025796C
		public vtkDataArray GetTCoords()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTCoords_73(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF68 RID: 110440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetTCoords_74(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF69 RID: 110441 RVA: 0x002597DC File Offset: 0x002579DC
		public vtkDataArray GetTCoords(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTCoords_74(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF6A RID: 110442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetTangents_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the tangent data.
		/// </summary>
		// Token: 0x0601AF6B RID: 110443 RVA: 0x0025984C File Offset: 0x00257A4C
		public vtkDataArray GetTangents()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTangents_75(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF6C RID: 110444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetTangents_76(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF6D RID: 110445 RVA: 0x002598BC File Offset: 0x00257ABC
		public vtkDataArray GetTangents(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTangents_76(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF6E RID: 110446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetTensors_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the tensor data.
		/// </summary>
		// Token: 0x0601AF6F RID: 110447 RVA: 0x0025992C File Offset: 0x00257B2C
		public vtkDataArray GetTensors()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTensors_77(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF70 RID: 110448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetTensors_78(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF71 RID: 110449 RVA: 0x0025999C File Offset: 0x00257B9C
		public vtkDataArray GetTensors(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTensors_78(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF72 RID: 110450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetVectors_79(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the vector data.
		/// </summary>
		// Token: 0x0601AF73 RID: 110451 RVA: 0x00259A0C File Offset: 0x00257C0C
		public vtkDataArray GetVectors()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetVectors_79(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF74 RID: 110452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GetVectors_80(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the string is nullptr or empty, calls the alternate method
		/// of the same name (that takes no parameters).
		/// Otherwise, it will look for an array with the correct name.
		/// If one exists, it is returned. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601AF75 RID: 110453 RVA: 0x00259A7C File Offset: 0x00257C7C
		public vtkDataArray GetVectors(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetVectors_80(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AF76 RID: 110454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_GhostArrayName_81();

		/// <summary>
		/// Shallow copy of data (i.e., use reference counting).
		/// Ignores the copy flags but preserves them in the output.
		/// </summary>
		// Token: 0x0601AF77 RID: 110455 RVA: 0x00259AEC File Offset: 0x00257CEC
		public static string GhostArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetAttributes.vtkDataSetAttributes_GhostArrayName_81());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601AF78 RID: 110456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_Initialize_82(HandleRef pThis);

		/// <summary>
		/// Initialize all of the object's data to nullptr
		/// Also, clear the copy flags.
		/// </summary>
		// Token: 0x0601AF79 RID: 110457 RVA: 0x00259B20 File Offset: 0x00257D20
		public override void Initialize()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_Initialize_82(base.GetCppThis());
		}

		// Token: 0x0601AF7A RID: 110458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_InterpolateAllocate_83(HandleRef pThis, HandleRef pd, long sze, long ext);

		/// <summary>
		/// Initialize point interpolation method.
		/// Note that pd HAS to be the vtkDataSetAttributes object which
		/// will later be used with InterpolatePoint or InterpolateEdge.
		/// ext is no longer used.
		/// If shallowCopyArrays is true, input arrays are copied to the output
		/// instead of new ones being allocated.
		/// </summary>
		// Token: 0x0601AF7B RID: 110459 RVA: 0x00259B30 File Offset: 0x00257D30
		public void InterpolateAllocate(vtkDataSetAttributes pd, long sze, long ext)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolateAllocate_83(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), sze, ext);
		}

		// Token: 0x0601AF7C RID: 110460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_InterpolateAllocate_84(HandleRef pThis, HandleRef pd, long sze, long ext, int shallowCopyArrays);

		/// <summary>
		/// Initialize point interpolation method.
		/// Note that pd HAS to be the vtkDataSetAttributes object which
		/// will later be used with InterpolatePoint or InterpolateEdge.
		/// ext is no longer used.
		/// If shallowCopyArrays is true, input arrays are copied to the output
		/// instead of new ones being allocated.
		/// </summary>
		// Token: 0x0601AF7D RID: 110461 RVA: 0x00259B64 File Offset: 0x00257D64
		public void InterpolateAllocate(vtkDataSetAttributes pd, long sze, long ext, int shallowCopyArrays)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolateAllocate_84(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), sze, ext, shallowCopyArrays);
		}

		// Token: 0x0601AF7E RID: 110462
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_InterpolateAllocate_85(HandleRef pThis, vtkDataSetAttributesFieldList list, long sze, long ext);

		/// <summary>
		/// A special form of InterpolateAllocate() to be used with FieldLists. Use it
		/// when you are interpolating data from a set of vtkDataSetAttributes.
		/// \c Warning: This does not copy the Information object associated with
		/// each data array. This behavior may change in the future.
		/// </summary>
		// Token: 0x0601AF7F RID: 110463 RVA: 0x00259B97 File Offset: 0x00257D97
		public void InterpolateAllocate(vtkDataSetAttributesFieldList list, long sze, long ext)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolateAllocate_85(base.GetCppThis(), list, sze, ext);
		}

		// Token: 0x0601AF80 RID: 110464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_InterpolateEdge_86(HandleRef pThis, HandleRef fromPd, long toId, long p1, long p2, double t);

		/// <summary>
		/// Interpolate data from the two points p1,p2 (forming an edge) and an
		/// interpolation factor, t, along the edge. The weight ranges from (0,1),
		/// with t=0 located at p1. Make sure that the method InterpolateAllocate()
		/// has been invoked before using this method.
		/// If the INTERPOLATION copy flag is set to 0 for an array, interpolation
		/// is prevented. If the flag is set to 1, weighted interpolation occurs.
		/// If the flag is set to 2, nearest neighbor interpolation is used.
		/// </summary>
		// Token: 0x0601AF81 RID: 110465 RVA: 0x00259BAC File Offset: 0x00257DAC
		public void InterpolateEdge(vtkDataSetAttributes fromPd, long toId, long p1, long p2, double t)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolateEdge_86(base.GetCppThis(), (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), toId, p1, p2, t);
		}

		// Token: 0x0601AF82 RID: 110466
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_InterpolatePoint_87(HandleRef pThis, HandleRef fromPd, long toId, HandleRef ids, IntPtr weights);

		/// <summary>
		/// Interpolate data set attributes from other data set attributes
		/// given cell or point ids and associated interpolation weights.
		/// If the INTERPOLATION copy flag is set to 0 for an array, interpolation
		/// is prevented. If the flag is set to 1, weighted interpolation occurs.
		/// If the flag is set to 2, nearest neighbor interpolation is used.
		/// </summary>
		// Token: 0x0601AF83 RID: 110467 RVA: 0x00259BE4 File Offset: 0x00257DE4
		public void InterpolatePoint(vtkDataSetAttributes fromPd, long toId, vtkIdList ids, IntPtr weights)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolatePoint_87(base.GetCppThis(), (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), toId, (ids == null) ? default(HandleRef) : ids.GetCppThis(), weights);
		}

		// Token: 0x0601AF84 RID: 110468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_InterpolatePoint_88(HandleRef pThis, vtkDataSetAttributesFieldList list, HandleRef fromPd, int idx, long toId, HandleRef ids, IntPtr weights);

		/// <summary>
		/// Interpolate data set attributes from other data set attributes
		/// given cell or point ids and associated interpolation weights.
		/// Make sure that special form of InterpolateAllocate() that accepts
		/// FieldList has been used.
		/// </summary>
		// Token: 0x0601AF85 RID: 110469 RVA: 0x00259C2C File Offset: 0x00257E2C
		public void InterpolatePoint(vtkDataSetAttributesFieldList list, vtkDataSetAttributes fromPd, int idx, long toId, vtkIdList ids, IntPtr weights)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolatePoint_88(base.GetCppThis(), list, (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), idx, toId, (ids == null) ? default(HandleRef) : ids.GetCppThis(), weights);
		}

		// Token: 0x0601AF86 RID: 110470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_InterpolateTime_89(HandleRef pThis, HandleRef from1, HandleRef from2, long id, double t);

		/// <summary>
		/// Interpolate data from the same id (point or cell) at different points
		/// in time (parameter t). Two input data set attributes objects are input.
		/// The parameter t lies between (0&lt;=t&lt;=1). IMPORTANT: it is assumed that
		/// the number of attributes and number of components is the same for both
		/// from1 and from2, and the type of data for from1 and from2 are the same.
		/// Make sure that the method InterpolateAllocate() has been invoked before
		/// using this method.
		/// If the INTERPOLATION copy flag is set to 0 for an array, interpolation
		/// is prevented. If the flag is set to 1, weighted interpolation occurs.
		/// If the flag is set to 2, nearest neighbor interpolation is used.
		/// </summary>
		// Token: 0x0601AF87 RID: 110471 RVA: 0x00259C78 File Offset: 0x00257E78
		public void InterpolateTime(vtkDataSetAttributes from1, vtkDataSetAttributes from2, long id, double t)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolateTime_89(base.GetCppThis(), (from1 == null) ? default(HandleRef) : from1.GetCppThis(), (from2 == null) ? default(HandleRef) : from2.GetCppThis(), id, t);
		}

		// Token: 0x0601AF88 RID: 110472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_IsA_90(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with copying turned on for all data.
		/// </summary>
		// Token: 0x0601AF89 RID: 110473 RVA: 0x00259CC0 File Offset: 0x00257EC0
		public override int IsA(string type)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_IsA_90(base.GetCppThis(), type);
		}

		// Token: 0x0601AF8A RID: 110474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_IsArrayAnAttribute_91(HandleRef pThis, int idx);

		/// <summary>
		/// Determine whether a data array of index idx is considered a data set
		/// attribute (i.e., scalar, vector, tensor, etc). Return less-than zero
		/// if it is, otherwise an index 0&lt;=idx&lt;NUM_ATTRIBUTES to indicate
		/// which attribute.
		/// </summary>
		// Token: 0x0601AF8B RID: 110475 RVA: 0x00259CE0 File Offset: 0x00257EE0
		public int IsArrayAnAttribute(int idx)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_IsArrayAnAttribute_91(base.GetCppThis(), idx);
		}

		// Token: 0x0601AF8C RID: 110476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_IsTypeOf_92([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with copying turned on for all data.
		/// </summary>
		// Token: 0x0601AF8D RID: 110477 RVA: 0x00259D00 File Offset: 0x00257F00
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_IsTypeOf_92(type);
		}

		// Token: 0x0601AF8E RID: 110478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_NewInstance_94(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with copying turned on for all data.
		/// </summary>
		// Token: 0x0601AF8F RID: 110479 RVA: 0x00259D1C File Offset: 0x00257F1C
		public new vtkDataSetAttributes NewInstance()
		{
			vtkDataSetAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_NewInstance_94(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AF90 RID: 110480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_PassData_95(HandleRef pThis, HandleRef fd);

		/// <summary>
		/// Pass entire arrays of input data through to output. Obey the "copy"
		/// flags. When passing a field, the following copying rules are
		/// followed: 1) Check if a field is an attribute, if yes and if there
		/// is a PASSDATA copy flag for that attribute (on or off), obey the flag
		/// for that attribute, ignore (2) and (3), 2) if there is a copy field for
		/// that field (on or off), obey the flag, ignore (3) 3) obey
		/// CopyAllOn/Off
		/// </summary>
		// Token: 0x0601AF91 RID: 110481 RVA: 0x00259D78 File Offset: 0x00257F78
		public override void PassData(vtkFieldData fd)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_PassData_95(base.GetCppThis(), (fd == null) ? default(HandleRef) : fd.GetCppThis());
		}

		// Token: 0x0601AF92 RID: 110482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_RemoveArray_96(HandleRef pThis, int index);

		/// <summary>
		/// Remove an array (with the given index) from the list of arrays.
		/// Does nothing if the index is out of range.
		/// </summary>
		// Token: 0x0601AF93 RID: 110483 RVA: 0x00259DA7 File Offset: 0x00257FA7
		public override void RemoveArray(int index)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_RemoveArray_96(base.GetCppThis(), index);
		}

		// Token: 0x0601AF94 RID: 110484
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAttributes_SafeDownCast_97(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with copying turned on for all data.
		/// </summary>
		// Token: 0x0601AF95 RID: 110485 RVA: 0x00259DB8 File Offset: 0x00257FB8
		public new static vtkDataSetAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_SafeDownCast_97((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601AF96 RID: 110486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveAttribute_98(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int attributeType);

		/// <summary>
		/// Make the array with the given name the active attribute.
		/// Attribute types are:
		/// vtkDataSetAttributes::SCALARS = 0
		/// vtkDataSetAttributes::VECTORS = 1
		/// vtkDataSetAttributes::NORMALS = 2
		/// vtkDataSetAttributes::TCOORDS = 3
		/// vtkDataSetAttributes::TENSORS = 4
		/// vtkDataSetAttributes::GLOBALIDS = 5
		/// vtkDataSetAttributes::PEDIGREEIDS = 6
		/// vtkDataSetAttributes::EDGEFLAG = 7
		/// vtkDataSetAttributes::TANGENTS = 8
		/// vtkDataSetAttributes::RATIONALWEIGHTS = 9
		/// vtkDataSetAttributes::HIGHERORDERDEGREES = 10
		/// vtkDataSetAttributes::PROCESSIDS = 11
		/// Returns the index of the array if successful, -1 if the array
		/// is not in the list of arrays.
		/// </summary>
		// Token: 0x0601AF97 RID: 110487 RVA: 0x00259E38 File Offset: 0x00258038
		public int SetActiveAttribute(string name, int attributeType)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveAttribute_98(base.GetCppThis(), name, attributeType);
		}

		// Token: 0x0601AF98 RID: 110488
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveAttribute_99(HandleRef pThis, int index, int attributeType);

		/// <summary>
		/// Make the array with the given index the active attribute.
		/// Returns the index of the array if successful, -1 if the array
		/// is not in the list of arrays.
		/// </summary>
		// Token: 0x0601AF99 RID: 110489 RVA: 0x00259E5C File Offset: 0x0025805C
		public int SetActiveAttribute(int index, int attributeType)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveAttribute_99(base.GetCppThis(), index, attributeType);
		}

		// Token: 0x0601AF9A RID: 110490
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveGlobalIds_100(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the global id data.
		/// </summary>
		// Token: 0x0601AF9B RID: 110491 RVA: 0x00259E80 File Offset: 0x00258080
		public int SetActiveGlobalIds(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveGlobalIds_100(base.GetCppThis(), name);
		}

		// Token: 0x0601AF9C RID: 110492
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveHigherOrderDegrees_101(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the rational degrees data.
		/// </summary>
		// Token: 0x0601AF9D RID: 110493 RVA: 0x00259EA0 File Offset: 0x002580A0
		public int SetActiveHigherOrderDegrees(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveHigherOrderDegrees_101(base.GetCppThis(), name);
		}

		// Token: 0x0601AF9E RID: 110494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveNormals_102(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/get the normal data.
		/// </summary>
		// Token: 0x0601AF9F RID: 110495 RVA: 0x00259EC0 File Offset: 0x002580C0
		public int SetActiveNormals(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveNormals_102(base.GetCppThis(), name);
		}

		// Token: 0x0601AFA0 RID: 110496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActivePedigreeIds_103(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the pedigree id data.
		/// </summary>
		// Token: 0x0601AFA1 RID: 110497 RVA: 0x00259EE0 File Offset: 0x002580E0
		public int SetActivePedigreeIds(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActivePedigreeIds_103(base.GetCppThis(), name);
		}

		// Token: 0x0601AFA2 RID: 110498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveProcessIds_104(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the process id data.
		/// </summary>
		// Token: 0x0601AFA3 RID: 110499 RVA: 0x00259F00 File Offset: 0x00258100
		public int SetActiveProcessIds(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveProcessIds_104(base.GetCppThis(), name);
		}

		// Token: 0x0601AFA4 RID: 110500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveRationalWeights_105(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the rational weights data.
		/// </summary>
		// Token: 0x0601AFA5 RID: 110501 RVA: 0x00259F20 File Offset: 0x00258120
		public int SetActiveRationalWeights(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveRationalWeights_105(base.GetCppThis(), name);
		}

		// Token: 0x0601AFA6 RID: 110502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveScalars_106(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the scalar data.
		/// </summary>
		// Token: 0x0601AFA7 RID: 110503 RVA: 0x00259F40 File Offset: 0x00258140
		public int SetActiveScalars(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveScalars_106(base.GetCppThis(), name);
		}

		// Token: 0x0601AFA8 RID: 110504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveTCoords_107(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the texture coordinate data.
		/// </summary>
		// Token: 0x0601AFA9 RID: 110505 RVA: 0x00259F60 File Offset: 0x00258160
		public int SetActiveTCoords(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveTCoords_107(base.GetCppThis(), name);
		}

		// Token: 0x0601AFAA RID: 110506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveTangents_108(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/get the tangent data.
		/// </summary>
		// Token: 0x0601AFAB RID: 110507 RVA: 0x00259F80 File Offset: 0x00258180
		public int SetActiveTangents(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveTangents_108(base.GetCppThis(), name);
		}

		// Token: 0x0601AFAC RID: 110508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveTensors_109(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the tensor data.
		/// </summary>
		// Token: 0x0601AFAD RID: 110509 RVA: 0x00259FA0 File Offset: 0x002581A0
		public int SetActiveTensors(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveTensors_109(base.GetCppThis(), name);
		}

		// Token: 0x0601AFAE RID: 110510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetActiveVectors_110(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set/Get the vector data.
		/// </summary>
		// Token: 0x0601AFAF RID: 110511 RVA: 0x00259FC0 File Offset: 0x002581C0
		public int SetActiveVectors(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveVectors_110(base.GetCppThis(), name);
		}

		// Token: 0x0601AFB0 RID: 110512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetAttribute_111(HandleRef pThis, HandleRef aa, int attributeType);

		/// <summary>
		/// Set an array to use as the given attribute type (i.e.,
		/// vtkDataSetAttributes::SCALAR, vtkDataSetAttributes::VECTOR,
		/// vtkDataSetAttributes::TENSOR, etc.). If this attribute was
		/// previously set to another array, that array is removed from the
		/// vtkDataSetAttributes object and the array aa is used as the
		/// attribute.
		///
		/// Returns the index of aa within the vtkDataSetAttributes object
		/// (i.e., the index to pass to the method GetArray(int) to obtain
		/// aa) if the attribute was set to aa successfully. If aa was
		/// already set as the given attributeType, returns the index of
		/// aa.
		///
		/// Returns -1 in the following cases:
		///
		/// - aa is nullptr (used to unset an attribute; not an error indicator)
		/// - aa is not a subclass of vtkDataArray, unless the attributeType
		/// is vtkDataSetAttributes::PEDIGREEIDS (error indicator)
		/// - aa has a number of components incompatible with the attribute type
		/// (error indicator)
		/// </summary>
		// Token: 0x0601AFB1 RID: 110513 RVA: 0x00259FE0 File Offset: 0x002581E0
		public int SetAttribute(vtkAbstractArray aa, int attributeType)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetAttribute_111(base.GetCppThis(), (aa == null) ? default(HandleRef) : aa.GetCppThis(), attributeType);
		}

		// Token: 0x0601AFB2 RID: 110514
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyAttribute_112(HandleRef pThis, int index, int value, int ctype);

		/// <summary>
		/// Turn on/off the copying of attribute data.
		/// ctype is one of the AttributeCopyOperations, and controls copy,
		/// interpolate and passdata behavior.
		/// For set, ctype=ALLCOPY means set all three flags to the same value.
		/// For get, ctype=ALLCOPY returns true only if all three flags are true.
		///
		/// During copying, interpolation and passdata, the following rules are
		/// followed for each array:
		/// 1. If the copy/interpolate/pass flag for an attribute is set (on or off),
		/// it is applied. This overrides rules 2 and 3.
		/// 2. If the copy flag for an array is set (on or off), it is applied
		/// This overrides rule 3.
		/// 3. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array
		///
		/// For interpolation, the flag values can be as follows:
		/// 0: Do not interpolate.
		/// 1: Weighted interpolation.
		/// 2: Nearest neighbor interpolation.
		/// </summary>
		// Token: 0x0601AFB3 RID: 110515 RVA: 0x0025A015 File Offset: 0x00258215
		public void SetCopyAttribute(int index, int value, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyAttribute_112(base.GetCppThis(), index, value, ctype);
		}

		// Token: 0x0601AFB4 RID: 110516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyGlobalIds_113(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFB5 RID: 110517 RVA: 0x0025A027 File Offset: 0x00258227
		public void SetCopyGlobalIds(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyGlobalIds_113(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFB6 RID: 110518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyHigherOrderDegrees_114(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFB7 RID: 110519 RVA: 0x0025A038 File Offset: 0x00258238
		public void SetCopyHigherOrderDegrees(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyHigherOrderDegrees_114(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFB8 RID: 110520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyNormals_115(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFB9 RID: 110521 RVA: 0x0025A049 File Offset: 0x00258249
		public void SetCopyNormals(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyNormals_115(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFBA RID: 110522
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyPedigreeIds_116(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFBB RID: 110523 RVA: 0x0025A05A File Offset: 0x0025825A
		public void SetCopyPedigreeIds(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyPedigreeIds_116(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFBC RID: 110524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyProcessIds_117(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFBD RID: 110525 RVA: 0x0025A06B File Offset: 0x0025826B
		public void SetCopyProcessIds(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyProcessIds_117(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFBE RID: 110526
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyRationalWeights_118(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFBF RID: 110527 RVA: 0x0025A07C File Offset: 0x0025827C
		public void SetCopyRationalWeights(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyRationalWeights_118(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFC0 RID: 110528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyScalars_119(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFC1 RID: 110529 RVA: 0x0025A08D File Offset: 0x0025828D
		public void SetCopyScalars(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyScalars_119(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFC2 RID: 110530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyTCoords_120(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFC3 RID: 110531 RVA: 0x0025A09E File Offset: 0x0025829E
		public void SetCopyTCoords(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyTCoords_120(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFC4 RID: 110532
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyTangents_121(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFC5 RID: 110533 RVA: 0x0025A0AF File Offset: 0x002582AF
		public void SetCopyTangents(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyTangents_121(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFC6 RID: 110534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyTensors_122(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFC7 RID: 110535 RVA: 0x0025A0C0 File Offset: 0x002582C0
		public void SetCopyTensors(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyTensors_122(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFC8 RID: 110536
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetCopyVectors_123(HandleRef pThis, int i, int ctype);

		/// <summary>
		/// Get the attribute copy flag for copy operation \c ctype of attribute
		/// \c index.
		/// </summary>
		// Token: 0x0601AFC9 RID: 110537 RVA: 0x0025A0D1 File Offset: 0x002582D1
		public void SetCopyVectors(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyVectors_123(base.GetCppThis(), i, ctype);
		}

		// Token: 0x0601AFCA RID: 110538
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetGlobalIds_124(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/Get the global id data.
		/// </summary>
		// Token: 0x0601AFCB RID: 110539 RVA: 0x0025A0E4 File Offset: 0x002582E4
		public int SetGlobalIds(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetGlobalIds_124(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFCC RID: 110540
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetHigherOrderDegrees_125(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/Get the rational degrees data.
		/// </summary>
		// Token: 0x0601AFCD RID: 110541 RVA: 0x0025A118 File Offset: 0x00258318
		public int SetHigherOrderDegrees(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetHigherOrderDegrees_125(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFCE RID: 110542
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetNormals_126(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/get the normal data.
		/// </summary>
		// Token: 0x0601AFCF RID: 110543 RVA: 0x0025A14C File Offset: 0x0025834C
		public int SetNormals(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetNormals_126(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFD0 RID: 110544
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetPedigreeIds_127(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/Get the pedigree id data.
		/// </summary>
		// Token: 0x0601AFD1 RID: 110545 RVA: 0x0025A180 File Offset: 0x00258380
		public int SetPedigreeIds(vtkAbstractArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetPedigreeIds_127(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFD2 RID: 110546
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetProcessIds_128(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/Get the process id data.
		/// </summary>
		// Token: 0x0601AFD3 RID: 110547 RVA: 0x0025A1B4 File Offset: 0x002583B4
		public int SetProcessIds(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetProcessIds_128(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFD4 RID: 110548
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetRationalWeights_129(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/Get the rational weights data.
		/// </summary>
		// Token: 0x0601AFD5 RID: 110549 RVA: 0x0025A1E8 File Offset: 0x002583E8
		public int SetRationalWeights(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetRationalWeights_129(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFD6 RID: 110550
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetScalars_130(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/Get the scalar data.
		/// </summary>
		// Token: 0x0601AFD7 RID: 110551 RVA: 0x0025A21C File Offset: 0x0025841C
		public int SetScalars(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetScalars_130(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFD8 RID: 110552
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetTCoords_131(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/Get the texture coordinate data.
		/// </summary>
		// Token: 0x0601AFD9 RID: 110553 RVA: 0x0025A250 File Offset: 0x00258450
		public int SetTCoords(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetTCoords_131(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFDA RID: 110554
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetTangents_132(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/get the tangent data.
		/// </summary>
		// Token: 0x0601AFDB RID: 110555 RVA: 0x0025A284 File Offset: 0x00258484
		public int SetTangents(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetTangents_132(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFDC RID: 110556
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetTensors_133(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/Get the tensor data.
		/// </summary>
		// Token: 0x0601AFDD RID: 110557 RVA: 0x0025A2B8 File Offset: 0x002584B8
		public int SetTensors(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetTensors_133(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFDE RID: 110558
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributes_SetVectors_134(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Set/Get the vector data.
		/// </summary>
		// Token: 0x0601AFDF RID: 110559 RVA: 0x0025A2EC File Offset: 0x002584EC
		public int SetVectors(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetVectors_134(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AFE0 RID: 110560
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_SetupForCopy_135(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Create a mapping between the input attributes and this object
		/// so that methods like CopyData() and CopyStructuredData()
		/// can be called. This method assumes that this object has the
		/// same arrays as the input and that they are ordered the same
		/// way (same array indices).
		/// </summary>
		// Token: 0x0601AFE1 RID: 110561 RVA: 0x0025A320 File Offset: 0x00258520
		public void SetupForCopy(vtkDataSetAttributes pd)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetupForCopy_135(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601AFE2 RID: 110562
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_ShallowCopy_136(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Shallow copy of data (i.e., use reference counting).
		/// Ignores the copy flags but preserves them in the output.
		/// </summary>
		// Token: 0x0601AFE3 RID: 110563 RVA: 0x0025A350 File Offset: 0x00258550
		public override void ShallowCopy(vtkFieldData pd)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_ShallowCopy_136(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601AFE4 RID: 110564
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributes_Update_137(HandleRef pThis);

		/// <summary>
		/// Attributes have a chance to bring themselves up to date; right
		/// now this is ignored.
		/// </summary>
		// Token: 0x0601AFE5 RID: 110565 RVA: 0x0025A37F File Offset: 0x0025857F
		public virtual void Update()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_Update_137(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D06 RID: 7430
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetAttributes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D07 RID: 7431
		public new static readonly string MRClassNameKey = "class vtkDataSetAttributes";

		/// <summary>
		/// Given an integer attribute type, this static method returns a string type
		/// for the attribute (i.e. type = 0: returns "Scalars").
		/// </summary>
		// Token: 0x02000A18 RID: 2584
		public enum AttributeCopyOperations
		{
			/// <summary>enum member</summary>
			// Token: 0x04001D09 RID: 7433
			ALLCOPY = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001D0A RID: 7434
			COPYTUPLE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001D0B RID: 7435
			INTERPOLATE,
			/// <summary>enum member</summary>
			// Token: 0x04001D0C RID: 7436
			PASSDATA
		}

		/// <summary>
		/// Shallow copy of data (i.e., use reference counting).
		/// Ignores the copy flags but preserves them in the output.
		/// </summary>
		// Token: 0x02000A19 RID: 2585
		public enum AttributeLimitTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001D0E RID: 7438
			EXACT = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001D0F RID: 7439
			MAX = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001D10 RID: 7440
			NOLIMIT = 2
		}

		/// <summary>
		/// Shallow copy of data (i.e., use reference counting).
		/// Ignores the copy flags but preserves them in the output.
		/// </summary>
		// Token: 0x02000A1A RID: 2586
		public enum AttributeTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001D12 RID: 7442
			EDGEFLAG = 7,
			/// <summary>enum member</summary>
			// Token: 0x04001D13 RID: 7443
			GLOBALIDS = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001D14 RID: 7444
			HIGHERORDERDEGREES = 10,
			/// <summary>enum member</summary>
			// Token: 0x04001D15 RID: 7445
			NORMALS = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001D16 RID: 7446
			NUM_ATTRIBUTES = 12,
			/// <summary>enum member</summary>
			// Token: 0x04001D17 RID: 7447
			PEDIGREEIDS = 6,
			/// <summary>enum member</summary>
			// Token: 0x04001D18 RID: 7448
			PROCESSIDS = 11,
			/// <summary>enum member</summary>
			// Token: 0x04001D19 RID: 7449
			RATIONALWEIGHTS = 9,
			/// <summary>enum member</summary>
			// Token: 0x04001D1A RID: 7450
			SCALARS = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001D1B RID: 7451
			TANGENTS = 8,
			/// <summary>enum member</summary>
			// Token: 0x04001D1C RID: 7452
			TCOORDS = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001D1D RID: 7453
			TENSORS,
			/// <summary>enum member</summary>
			// Token: 0x04001D1E RID: 7454
			VECTORS = 1
		}

		/// <summary>
		/// Shallow copy of data (i.e., use reference counting).
		/// Ignores the copy flags but preserves them in the output.
		/// </summary>
		// Token: 0x02000A1B RID: 2587
		public enum CellGhostTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001D20 RID: 7456
			DUPLICATECELL = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001D21 RID: 7457
			EXTERIORCELL = 16,
			/// <summary>enum member</summary>
			// Token: 0x04001D22 RID: 7458
			HIDDENCELL = 32,
			/// <summary>enum member</summary>
			// Token: 0x04001D23 RID: 7459
			HIGHCONNECTIVITYCELL = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001D24 RID: 7460
			LOWCONNECTIVITYCELL = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001D25 RID: 7461
			REFINEDCELL = 8
		}

		/// <summary>
		/// Shallow copy of data (i.e., use reference counting).
		/// Ignores the copy flags but preserves them in the output.
		/// </summary>
		// Token: 0x02000A1C RID: 2588
		public enum PointGhostTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001D27 RID: 7463
			DUPLICATEPOINT = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001D28 RID: 7464
			HIDDENPOINT
		}
	}
}
