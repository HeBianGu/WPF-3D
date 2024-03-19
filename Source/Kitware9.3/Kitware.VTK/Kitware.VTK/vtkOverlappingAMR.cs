using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOverlappingAMR
	/// </summary>
	/// <remarks>
	///    hierarchical dataset of vtkUniformGrids
	///
	///
	/// vtkOverlappingAMR extends vtkUniformGridAMR by exposing access to the
	/// amr meta data, which stores all structural information represented
	/// by an vtkAMRInformation object
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAMRInformation
	/// </seealso>
	// Token: 0x02000A5B RID: 2651
	public class vtkOverlappingAMR : vtkUniformGridAMR
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BB0A RID: 113418 RVA: 0x0026C4B7 File Offset: 0x0026A6B7
		static vtkOverlappingAMR()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOverlappingAMR.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverlappingAMR"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BB0B RID: 113419 RVA: 0x0026C4DF File Offset: 0x0026A6DF
		public vtkOverlappingAMR(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BB0C RID: 113420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB0D RID: 113421 RVA: 0x0026C4F0 File Offset: 0x0026A6F0
		public new static vtkOverlappingAMR New()
		{
			vtkOverlappingAMR result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMR.vtkOverlappingAMR_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB0E RID: 113422 RVA: 0x0026C544 File Offset: 0x0026A744
		public vtkOverlappingAMR() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOverlappingAMR.vtkOverlappingAMR_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BB0F RID: 113423 RVA: 0x0026C588 File Offset: 0x0026A788
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BB10 RID: 113424
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_Audit_01(HandleRef pThis);

		/// <summary>
		/// Check whether the data set is internally consistent, e.g.
		/// whether the meta data and actual data blocks match.
		/// Incorrectness will be reported as error messages
		/// </summary>
		// Token: 0x0601BB11 RID: 113425 RVA: 0x0026C593 File Offset: 0x0026A793
		public void Audit()
		{
			vtkOverlappingAMR.vtkOverlappingAMR_Audit_01(base.GetCppThis());
		}

		// Token: 0x0601BB12 RID: 113426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOverlappingAMR_FindGrid_02(HandleRef pThis, IntPtr q, ref uint level, ref uint gridId);

		/// <summary>
		/// Given a point q, find the highest level grid that contains it.
		/// </summary>
		// Token: 0x0601BB13 RID: 113427 RVA: 0x0026C5A4 File Offset: 0x0026A7A4
		public bool FindGrid(IntPtr q, ref uint level, ref uint gridId)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_FindGrid_02(base.GetCppThis(), q, ref level, ref gridId) != 0;
		}

		// Token: 0x0601BB14 RID: 113428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_GenerateParentChildInformation_03(HandleRef pThis);

		/// <summary>
		/// Generate the parent/child relationships - needed to be called
		/// before GetParents or GetChildren can be used!
		/// </summary>
		// Token: 0x0601BB15 RID: 113429 RVA: 0x0026C5CD File Offset: 0x0026A7CD
		public void GenerateParentChildInformation()
		{
			vtkOverlappingAMR.vtkOverlappingAMR_GenerateParentChildInformation_03(base.GetCppThis());
		}

		// Token: 0x0601BB16 RID: 113430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMR_GetAMRBlockSourceIndex_04(HandleRef pThis, uint level, uint id);

		/// <summary>
		/// Set/Get the source id of a block. The source id is produced by an
		/// AMR source, e.g. a file reader might set this to be a file block id
		/// </summary>
		// Token: 0x0601BB17 RID: 113431 RVA: 0x0026C5DC File Offset: 0x0026A7DC
		public int GetAMRBlockSourceIndex(uint level, uint id)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_GetAMRBlockSourceIndex_04(base.GetCppThis(), level, id);
		}

		// Token: 0x0601BB18 RID: 113432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_GetAMRInfo_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the internal representation of amr meta meta data
		/// </summary>
		// Token: 0x0601BB19 RID: 113433 RVA: 0x0026C600 File Offset: 0x0026A800
		public virtual vtkAMRInformation GetAMRInfo()
		{
			vtkAMRInformation vtkAMRInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMR.vtkOverlappingAMR_GetAMRInfo_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRInformation = (vtkAMRInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRInformation.Register(null);
				}
			}
			return vtkAMRInformation;
		}

		// Token: 0x0601BB1A RID: 113434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_GetBounds_06(HandleRef pThis, uint level, uint id, IntPtr bb);

		/// <summary>
		/// Returns the bounding information of a data set.
		/// </summary>
		// Token: 0x0601BB1B RID: 113435 RVA: 0x0026C66F File Offset: 0x0026A86F
		public void GetBounds(uint level, uint id, IntPtr bb)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_GetBounds_06(base.GetCppThis(), level, id, bb);
		}

		// Token: 0x0601BB1C RID: 113436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_GetBounds_07(HandleRef pThis, IntPtr b);

		/// <summary>
		/// Prints the parents and children of a requested block (Debug Routine)
		/// </summary>
		// Token: 0x0601BB1D RID: 113437 RVA: 0x0026C681 File Offset: 0x0026A881
		public new void GetBounds(IntPtr b)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_GetBounds_07(base.GetCppThis(), b);
		}

		// Token: 0x0601BB1E RID: 113438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_GetChildren_08(HandleRef pThis, uint level, uint index, ref uint numChildren);

		/// <summary>
		/// Return a pointer to Children of a block.  The first entry is the number
		/// of children the block has followed by its children ids in level+1.
		/// If none exits it returns nullptr.
		/// </summary>
		// Token: 0x0601BB1F RID: 113439 RVA: 0x0026C694 File Offset: 0x0026A894
		public IntPtr GetChildren(uint level, uint index, ref uint numChildren)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_GetChildren_08(base.GetCppThis(), level, index, ref numChildren);
		}

		// Token: 0x0601BB20 RID: 113440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_GetData_09(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601BB21 RID: 113441 RVA: 0x0026C6B8 File Offset: 0x0026A8B8
		public new static vtkOverlappingAMR GetData(vtkInformation info)
		{
			vtkOverlappingAMR vtkOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMR.vtkOverlappingAMR_GetData_09((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlappingAMR = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlappingAMR.Register(null);
				}
			}
			return vtkOverlappingAMR;
		}

		// Token: 0x0601BB22 RID: 113442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_GetData_10(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601BB23 RID: 113443 RVA: 0x0026C738 File Offset: 0x0026A938
		public new static vtkOverlappingAMR GetData(vtkInformationVector v, int i)
		{
			vtkOverlappingAMR vtkOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMR.vtkOverlappingAMR_GetData_10((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlappingAMR = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlappingAMR.Register(null);
				}
			}
			return vtkOverlappingAMR;
		}

		// Token: 0x0601BB24 RID: 113444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMR_GetDataObjectType_11(HandleRef pThis);

		/// <summary>
		/// Return class name of data type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601BB25 RID: 113445 RVA: 0x0026C7B8 File Offset: 0x0026A9B8
		public override int GetDataObjectType()
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_GetDataObjectType_11(base.GetCppThis());
		}

		// Token: 0x0601BB26 RID: 113446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverlappingAMR_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return class name of data type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601BB27 RID: 113447 RVA: 0x0026C7D8 File Offset: 0x0026A9D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601BB28 RID: 113448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverlappingAMR_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return class name of data type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601BB29 RID: 113449 RVA: 0x0026C7F8 File Offset: 0x0026A9F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601BB2A RID: 113450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_GetOrigin_14(HandleRef pThis);

		/// <summary>
		/// Get/Set the global origin of the amr data set
		/// </summary>
		// Token: 0x0601BB2B RID: 113451 RVA: 0x0026C814 File Offset: 0x0026AA14
		public IntPtr GetOrigin()
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_GetOrigin_14(base.GetCppThis());
		}

		// Token: 0x0601BB2C RID: 113452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_GetOrigin_15(HandleRef pThis, uint level, uint id, IntPtr origin);

		/// <summary>
		/// Returns the origin of an AMR block
		/// </summary>
		// Token: 0x0601BB2D RID: 113453 RVA: 0x0026C833 File Offset: 0x0026AA33
		public void GetOrigin(uint level, uint id, IntPtr origin)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_GetOrigin_15(base.GetCppThis(), level, id, origin);
		}

		// Token: 0x0601BB2E RID: 113454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_GetParents_16(HandleRef pThis, uint level, uint index, ref uint numParents);

		/// <summary>
		/// Return a pointer to Parents of a block.  The first entry is the number
		/// of parents the block has followed by its parent ids in level-1.
		/// If none exits it returns nullptr.
		/// </summary>
		// Token: 0x0601BB2F RID: 113455 RVA: 0x0026C848 File Offset: 0x0026AA48
		public IntPtr GetParents(uint level, uint index, ref uint numParents)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_GetParents_16(base.GetCppThis(), level, index, ref numParents);
		}

		// Token: 0x0601BB30 RID: 113456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMR_GetRefinementRatio_17(HandleRef pThis, uint level);

		/// <summary>
		/// Returns the refinement of a given level.
		/// </summary>
		// Token: 0x0601BB31 RID: 113457 RVA: 0x0026C86C File Offset: 0x0026AA6C
		public int GetRefinementRatio(uint level)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_GetRefinementRatio_17(base.GetCppThis(), level);
		}

		// Token: 0x0601BB32 RID: 113458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMR_GetRefinementRatio_18(HandleRef pThis, HandleRef iter);

		/// <summary>
		/// Returns the refinement ratio for the position pointed by the iterator.
		/// </summary>
		// Token: 0x0601BB33 RID: 113459 RVA: 0x0026C88C File Offset: 0x0026AA8C
		public int GetRefinementRatio(vtkCompositeDataIterator iter)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_GetRefinementRatio_18(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		// Token: 0x0601BB34 RID: 113460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_GetSpacing_19(HandleRef pThis, uint level, IntPtr spacing);

		/// <summary>
		/// Get/Set the grid spacing at a given level
		/// </summary>
		// Token: 0x0601BB35 RID: 113461 RVA: 0x0026C8C0 File Offset: 0x0026AAC0
		public void GetSpacing(uint level, IntPtr spacing)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_GetSpacing_19(base.GetCppThis(), level, spacing);
		}

		// Token: 0x0601BB36 RID: 113462
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOverlappingAMR_HasChildrenInformation_20(HandleRef pThis);

		/// <summary>
		/// Return whether parent child information has been generated
		/// </summary>
		// Token: 0x0601BB37 RID: 113463 RVA: 0x0026C8D4 File Offset: 0x0026AAD4
		public bool HasChildrenInformation()
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_HasChildrenInformation_20(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BB38 RID: 113464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMR_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return class name of data type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601BB39 RID: 113465 RVA: 0x0026C8FC File Offset: 0x0026AAFC
		public override int IsA(string type)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0601BB3A RID: 113466
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMR_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return class name of data type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601BB3B RID: 113467 RVA: 0x0026C91C File Offset: 0x0026AB1C
		public new static int IsTypeOf(string type)
		{
			return vtkOverlappingAMR.vtkOverlappingAMR_IsTypeOf_22(type);
		}

		// Token: 0x0601BB3C RID: 113468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_NUMBER_OF_BLANKED_POINTS_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the origin of an AMR block
		/// </summary>
		// Token: 0x0601BB3D RID: 113469 RVA: 0x0026C938 File Offset: 0x0026AB38
		public static vtkInformationIdTypeKey NUMBER_OF_BLANKED_POINTS()
		{
			vtkInformationIdTypeKey vtkInformationIdTypeKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMR.vtkOverlappingAMR_NUMBER_OF_BLANKED_POINTS_23(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIdTypeKey = (vtkInformationIdTypeKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIdTypeKey.Register(null);
				}
			}
			return vtkInformationIdTypeKey;
		}

		// Token: 0x0601BB3E RID: 113470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return class name of data type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601BB3F RID: 113471 RVA: 0x0026C9A4 File Offset: 0x0026ABA4
		public new vtkOverlappingAMR NewInstance()
		{
			vtkOverlappingAMR result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMR.vtkOverlappingAMR_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BB40 RID: 113472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_NewIterator_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a new iterator (the iterator has to be deleted by the user).
		/// </summary>
		// Token: 0x0601BB41 RID: 113473 RVA: 0x0026CA00 File Offset: 0x0026AC00
		public override vtkCompositeDataIterator NewIterator()
		{
			vtkCompositeDataIterator vtkCompositeDataIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMR.vtkOverlappingAMR_NewIterator_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataIterator = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataIterator.Register(null);
				}
			}
			return vtkCompositeDataIterator;
		}

		// Token: 0x0601BB42 RID: 113474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_PrintParentChildInfo_27(HandleRef pThis, uint level, uint index);

		/// <summary>
		/// Prints the parents and children of a requested block (Debug Routine)
		/// </summary>
		// Token: 0x0601BB43 RID: 113475 RVA: 0x0026CA6F File Offset: 0x0026AC6F
		public void PrintParentChildInfo(uint level, uint index)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_PrintParentChildInfo_27(base.GetCppThis(), level, index);
		}

		// Token: 0x0601BB44 RID: 113476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMR_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return class name of data type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601BB45 RID: 113477 RVA: 0x0026CA80 File Offset: 0x0026AC80
		public new static vtkOverlappingAMR SafeDownCast(vtkObjectBase o)
		{
			vtkOverlappingAMR vtkOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMR.vtkOverlappingAMR_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlappingAMR = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlappingAMR.Register(null);
				}
			}
			return vtkOverlappingAMR;
		}

		// Token: 0x0601BB46 RID: 113478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_SetAMRBlockSourceIndex_29(HandleRef pThis, uint level, uint id, int sourceId);

		/// <summary>
		/// Set/Get the source id of a block. The source id is produced by an
		/// AMR source, e.g. a file reader might set this to be a file block id
		/// </summary>
		// Token: 0x0601BB47 RID: 113479 RVA: 0x0026CAFF File Offset: 0x0026ACFF
		public void SetAMRBlockSourceIndex(uint level, uint id, int sourceId)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_SetAMRBlockSourceIndex_29(base.GetCppThis(), level, id, sourceId);
		}

		// Token: 0x0601BB48 RID: 113480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_SetAMRInfo_30(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the internal representation of amr meta meta data
		/// </summary>
		// Token: 0x0601BB49 RID: 113481 RVA: 0x0026CB14 File Offset: 0x0026AD14
		public virtual void SetAMRInfo(vtkAMRInformation info)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_SetAMRInfo_30(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601BB4A RID: 113482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_SetOrigin_31(HandleRef pThis, IntPtr origin);

		/// <summary>
		/// Get/Set the global origin of the amr data set
		/// </summary>
		// Token: 0x0601BB4B RID: 113483 RVA: 0x0026CB43 File Offset: 0x0026AD43
		public void SetOrigin(IntPtr origin)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_SetOrigin_31(base.GetCppThis(), origin);
		}

		// Token: 0x0601BB4C RID: 113484
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_SetRefinementRatio_32(HandleRef pThis, uint level, int refRatio);

		/// <summary>
		/// Sets the refinement of a given level. The spacing at level
		/// level+1 is defined as spacing(level+1) = spacing(level)/refRatio(level).
		/// Note that currently, this is not enforced by this class however
		/// some algorithms might not function properly if the spacing in
		/// the blocks (vtkUniformGrid) does not match the one described
		/// by the refinement ratio.
		/// </summary>
		// Token: 0x0601BB4D RID: 113485 RVA: 0x0026CB53 File Offset: 0x0026AD53
		public void SetRefinementRatio(uint level, int refRatio)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_SetRefinementRatio_32(base.GetCppThis(), level, refRatio);
		}

		// Token: 0x0601BB4E RID: 113486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverlappingAMR_SetSpacing_33(HandleRef pThis, uint level, IntPtr spacing);

		/// <summary>
		/// Get/Set the grid spacing at a given level
		/// </summary>
		// Token: 0x0601BB4F RID: 113487 RVA: 0x0026CB64 File Offset: 0x0026AD64
		public void SetSpacing(uint level, IntPtr spacing)
		{
			vtkOverlappingAMR.vtkOverlappingAMR_SetSpacing_33(base.GetCppThis(), level, spacing);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DAA RID: 7594
		public new const string MRFullTypeName = "Kitware.VTK.vtkOverlappingAMR";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DAB RID: 7595
		public new static readonly string MRClassNameKey = "class vtkOverlappingAMR";
	}
}
