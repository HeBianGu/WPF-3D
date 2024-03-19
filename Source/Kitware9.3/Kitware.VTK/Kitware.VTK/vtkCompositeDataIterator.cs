using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataIterator
	/// </summary>
	/// <remarks>
	///    superclass for composite data iterators
	///
	/// vtkCompositeDataIterator provides an interface for accessing datasets
	/// in a collection (vtkCompositeDataIterator).
	/// </remarks>
	// Token: 0x02000A2F RID: 2607
	public abstract class vtkCompositeDataIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B26A RID: 111210 RVA: 0x0025EAF7 File Offset: 0x0025CCF7
		static vtkCompositeDataIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B26B RID: 111211 RVA: 0x0025EB1F File Offset: 0x0025CD1F
		public vtkCompositeDataIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B26C RID: 111212 RVA: 0x0025EB2D File Offset: 0x0025CD2D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B26D RID: 111213
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataIterator_GetCurrentDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the current item. Valid only when IsDoneWithTraversal() returns 0.
		/// </summary>
		// Token: 0x0601B26E RID: 111214 RVA: 0x0025EB38 File Offset: 0x0025CD38
		public virtual vtkDataObject GetCurrentDataObject()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_GetCurrentDataObject_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601B26F RID: 111215
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCompositeDataIterator_GetCurrentFlatIndex_02(HandleRef pThis);

		/// <summary>
		/// Flat index is an index to identify the data in a composite data structure
		/// </summary>
		// Token: 0x0601B270 RID: 111216 RVA: 0x0025EBA8 File Offset: 0x0025CDA8
		public virtual uint GetCurrentFlatIndex()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetCurrentFlatIndex_02(base.GetCppThis());
		}

		// Token: 0x0601B271 RID: 111217
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataIterator_GetCurrentMetaData_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the meta-data associated with the current item. This will allocate
		/// a new vtkInformation object is none is already present. Use
		/// HasCurrentMetaData to avoid unnecessary creation of vtkInformation objects.
		/// </summary>
		// Token: 0x0601B272 RID: 111218 RVA: 0x0025EBC8 File Offset: 0x0025CDC8
		public virtual vtkInformation GetCurrentMetaData()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_GetCurrentMetaData_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0601B273 RID: 111219
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataIterator_GetDataSet_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the composite dataset this iterator is iterating over.
		/// Must be set before traversal begins.
		/// </summary>
		// Token: 0x0601B274 RID: 111220 RVA: 0x0025EC38 File Offset: 0x0025CE38
		public virtual vtkCompositeDataSet GetDataSet()
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_GetDataSet_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x0601B275 RID: 111221
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataIterator_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B276 RID: 111222 RVA: 0x0025ECA8 File Offset: 0x0025CEA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601B277 RID: 111223
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataIterator_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B278 RID: 111224 RVA: 0x0025ECC8 File Offset: 0x0025CEC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601B279 RID: 111225
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataIterator_GetReverse_07(HandleRef pThis);

		/// <summary>
		/// Returns if the iteration is in reverse order.
		/// </summary>
		// Token: 0x0601B27A RID: 111226 RVA: 0x0025ECE4 File Offset: 0x0025CEE4
		public virtual int GetReverse()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetReverse_07(base.GetCppThis());
		}

		// Token: 0x0601B27B RID: 111227
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataIterator_GetSkipEmptyNodes_08(HandleRef pThis);

		/// <summary>
		/// If SkipEmptyNodes is true, then nullptr datasets will be skipped. Default is
		/// true.
		/// </summary>
		// Token: 0x0601B27C RID: 111228 RVA: 0x0025ED04 File Offset: 0x0025CF04
		public virtual int GetSkipEmptyNodes()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetSkipEmptyNodes_08(base.GetCppThis());
		}

		// Token: 0x0601B27D RID: 111229
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataIterator_GoToFirstItem_09(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the beginning of the collection.
		/// </summary>
		// Token: 0x0601B27E RID: 111230 RVA: 0x0025ED23 File Offset: 0x0025CF23
		public virtual void GoToFirstItem()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_GoToFirstItem_09(base.GetCppThis());
		}

		// Token: 0x0601B27F RID: 111231
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataIterator_GoToNextItem_10(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the next item in the collection.
		/// </summary>
		// Token: 0x0601B280 RID: 111232 RVA: 0x0025ED32 File Offset: 0x0025CF32
		public virtual void GoToNextItem()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_GoToNextItem_10(base.GetCppThis());
		}

		// Token: 0x0601B281 RID: 111233
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataIterator_HasCurrentMetaData_11(HandleRef pThis);

		/// <summary>
		/// Returns if the a meta-data information object is present for the current
		/// item. Return 1 on success, 0 otherwise.
		/// </summary>
		// Token: 0x0601B282 RID: 111234 RVA: 0x0025ED44 File Offset: 0x0025CF44
		public virtual int HasCurrentMetaData()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_HasCurrentMetaData_11(base.GetCppThis());
		}

		// Token: 0x0601B283 RID: 111235
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataIterator_InitReverseTraversal_12(HandleRef pThis);

		/// <summary>
		/// Begin iterating over the composite dataset structure in reverse order.
		/// </summary>
		// Token: 0x0601B284 RID: 111236 RVA: 0x0025ED63 File Offset: 0x0025CF63
		public virtual void InitReverseTraversal()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_InitReverseTraversal_12(base.GetCppThis());
		}

		// Token: 0x0601B285 RID: 111237
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataIterator_InitTraversal_13(HandleRef pThis);

		/// <summary>
		/// Begin iterating over the composite dataset structure.
		/// </summary>
		// Token: 0x0601B286 RID: 111238 RVA: 0x0025ED72 File Offset: 0x0025CF72
		public virtual void InitTraversal()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_InitTraversal_13(base.GetCppThis());
		}

		// Token: 0x0601B287 RID: 111239
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataIterator_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B288 RID: 111240 RVA: 0x0025ED84 File Offset: 0x0025CF84
		public override int IsA(string type)
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0601B289 RID: 111241
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataIterator_IsDoneWithTraversal_15(HandleRef pThis);

		/// <summary>
		/// Test whether the iterator is finished with the traversal.
		/// Returns 1 for yes, and 0 for no.
		/// It is safe to call any of the GetCurrent...() methods only when
		/// IsDoneWithTraversal() returns 0.
		/// </summary>
		// Token: 0x0601B28A RID: 111242 RVA: 0x0025EDA4 File Offset: 0x0025CFA4
		public virtual int IsDoneWithTraversal()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_IsDoneWithTraversal_15(base.GetCppThis());
		}

		// Token: 0x0601B28B RID: 111243
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataIterator_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B28C RID: 111244 RVA: 0x0025EDC4 File Offset: 0x0025CFC4
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_IsTypeOf_16(type);
		}

		// Token: 0x0601B28D RID: 111245
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataIterator_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B28E RID: 111246 RVA: 0x0025EDE0 File Offset: 0x0025CFE0
		public new vtkCompositeDataIterator NewInstance()
		{
			vtkCompositeDataIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B28F RID: 111247
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataIterator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B290 RID: 111248 RVA: 0x0025EE3C File Offset: 0x0025D03C
		public new static vtkCompositeDataIterator SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataIterator vtkCompositeDataIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B291 RID: 111249
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataIterator_SetDataSet_19(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Set the composite dataset this iterator is iterating over.
		/// Must be set before traversal begins.
		/// </summary>
		// Token: 0x0601B292 RID: 111250 RVA: 0x0025EEBC File Offset: 0x0025D0BC
		public virtual void SetDataSet(vtkCompositeDataSet ds)
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SetDataSet_19(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601B293 RID: 111251
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataIterator_SetSkipEmptyNodes_20(HandleRef pThis, int _arg);

		/// <summary>
		/// If SkipEmptyNodes is true, then nullptr datasets will be skipped. Default is
		/// true.
		/// </summary>
		// Token: 0x0601B294 RID: 111252 RVA: 0x0025EEEB File Offset: 0x0025D0EB
		public virtual void SetSkipEmptyNodes(int _arg)
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SetSkipEmptyNodes_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B295 RID: 111253
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataIterator_SkipEmptyNodesOff_21(HandleRef pThis);

		/// <summary>
		/// If SkipEmptyNodes is true, then nullptr datasets will be skipped. Default is
		/// true.
		/// </summary>
		// Token: 0x0601B296 RID: 111254 RVA: 0x0025EEFB File Offset: 0x0025D0FB
		public virtual void SkipEmptyNodesOff()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SkipEmptyNodesOff_21(base.GetCppThis());
		}

		// Token: 0x0601B297 RID: 111255
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataIterator_SkipEmptyNodesOn_22(HandleRef pThis);

		/// <summary>
		/// If SkipEmptyNodes is true, then nullptr datasets will be skipped. Default is
		/// true.
		/// </summary>
		// Token: 0x0601B298 RID: 111256 RVA: 0x0025EF0A File Offset: 0x0025D10A
		public virtual void SkipEmptyNodesOn()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SkipEmptyNodesOn_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D51 RID: 7505
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D52 RID: 7506
		public new static readonly string MRClassNameKey = "class vtkCompositeDataIterator";
	}
}
