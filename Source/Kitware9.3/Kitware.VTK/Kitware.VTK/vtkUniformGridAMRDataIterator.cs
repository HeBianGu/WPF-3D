using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUniformGridAMRDataIterator
	/// </summary>
	/// <remarks>
	///    subclass of vtkCompositeDataIterator
	/// with API to get current level and dataset index.
	///
	/// </remarks>
	// Token: 0x02000A58 RID: 2648
	public class vtkUniformGridAMRDataIterator : vtkCompositeDataIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BA90 RID: 113296 RVA: 0x0026B791 File Offset: 0x00269991
		static vtkUniformGridAMRDataIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUniformGridAMRDataIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGridAMRDataIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BA91 RID: 113297 RVA: 0x0026B7B9 File Offset: 0x002699B9
		public vtkUniformGridAMRDataIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BA92 RID: 113298
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRDataIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA93 RID: 113299 RVA: 0x0026B7C8 File Offset: 0x002699C8
		public new static vtkUniformGridAMRDataIterator New()
		{
			vtkUniformGridAMRDataIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGridAMRDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA94 RID: 113300 RVA: 0x0026B81C File Offset: 0x00269A1C
		public vtkUniformGridAMRDataIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BA95 RID: 113301 RVA: 0x0026B860 File Offset: 0x00269A60
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BA96 RID: 113302
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRDataIterator_GetCurrentDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the current item. Valid only when IsDoneWithTraversal() returns 0.
		/// </summary>
		// Token: 0x0601BA97 RID: 113303 RVA: 0x0026B86C File Offset: 0x00269A6C
		public override vtkDataObject GetCurrentDataObject()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_GetCurrentDataObject_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BA98 RID: 113304
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUniformGridAMRDataIterator_GetCurrentFlatIndex_02(HandleRef pThis);

		/// <summary>
		/// Flat index is an index obtained by traversing the tree in preorder.
		/// This can be used to uniquely identify nodes in the tree.
		/// Not valid if IsDoneWithTraversal() returns true.
		/// </summary>
		// Token: 0x0601BA99 RID: 113305 RVA: 0x0026B8DC File Offset: 0x00269ADC
		public override uint GetCurrentFlatIndex()
		{
			return vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_GetCurrentFlatIndex_02(base.GetCppThis());
		}

		// Token: 0x0601BA9A RID: 113306
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUniformGridAMRDataIterator_GetCurrentIndex_03(HandleRef pThis);

		/// <summary>
		/// Returns the dataset index for the current data object. Valid only if the
		/// current data is a leaf node i.e. no a composite dataset.
		/// </summary>
		// Token: 0x0601BA9B RID: 113307 RVA: 0x0026B8FC File Offset: 0x00269AFC
		public virtual uint GetCurrentIndex()
		{
			return vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_GetCurrentIndex_03(base.GetCppThis());
		}

		// Token: 0x0601BA9C RID: 113308
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUniformGridAMRDataIterator_GetCurrentLevel_04(HandleRef pThis);

		/// <summary>
		/// Returns the level for the current dataset.
		/// </summary>
		// Token: 0x0601BA9D RID: 113309 RVA: 0x0026B91C File Offset: 0x00269B1C
		public virtual uint GetCurrentLevel()
		{
			return vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_GetCurrentLevel_04(base.GetCppThis());
		}

		// Token: 0x0601BA9E RID: 113310
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRDataIterator_GetCurrentMetaData_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the meta-data associated with the current item.
		/// Note that this points to a single instance of vtkInformation object
		/// allocated by the iterator and will be changed as soon as GoToNextItem is
		/// called.
		/// </summary>
		// Token: 0x0601BA9F RID: 113311 RVA: 0x0026B93C File Offset: 0x00269B3C
		public override vtkInformation GetCurrentMetaData()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_GetCurrentMetaData_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BAA0 RID: 113312
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGridAMRDataIterator_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAA1 RID: 113313 RVA: 0x0026B9AC File Offset: 0x00269BAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601BAA2 RID: 113314
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGridAMRDataIterator_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAA3 RID: 113315 RVA: 0x0026B9CC File Offset: 0x00269BCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601BAA4 RID: 113316
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMRDataIterator_GoToFirstItem_08(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the beginning of the collection.
		/// </summary>
		// Token: 0x0601BAA5 RID: 113317 RVA: 0x0026B9E6 File Offset: 0x00269BE6
		public override void GoToFirstItem()
		{
			vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_GoToFirstItem_08(base.GetCppThis());
		}

		// Token: 0x0601BAA6 RID: 113318
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMRDataIterator_GoToNextItem_09(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the next item in the collection.
		/// </summary>
		// Token: 0x0601BAA7 RID: 113319 RVA: 0x0026B9F5 File Offset: 0x00269BF5
		public override void GoToNextItem()
		{
			vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_GoToNextItem_09(base.GetCppThis());
		}

		// Token: 0x0601BAA8 RID: 113320
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMRDataIterator_HasCurrentMetaData_10(HandleRef pThis);

		/// <summary>
		/// Returns the meta-data associated with the current item.
		/// Note that this points to a single instance of vtkInformation object
		/// allocated by the iterator and will be changed as soon as GoToNextItem is
		/// called.
		/// </summary>
		// Token: 0x0601BAA9 RID: 113321 RVA: 0x0026BA04 File Offset: 0x00269C04
		public override int HasCurrentMetaData()
		{
			return vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_HasCurrentMetaData_10(base.GetCppThis());
		}

		// Token: 0x0601BAAA RID: 113322
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMRDataIterator_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAAB RID: 113323 RVA: 0x0026BA24 File Offset: 0x00269C24
		public override int IsA(string type)
		{
			return vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601BAAC RID: 113324
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMRDataIterator_IsDoneWithTraversal_12(HandleRef pThis);

		/// <summary>
		/// Test whether the iterator is finished with the traversal.
		/// Returns 1 for yes, and 0 for no.
		/// It is safe to call any of the GetCurrent...() methods only when
		/// IsDoneWithTraversal() returns 0.
		/// </summary>
		// Token: 0x0601BAAD RID: 113325 RVA: 0x0026BA44 File Offset: 0x00269C44
		public override int IsDoneWithTraversal()
		{
			return vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_IsDoneWithTraversal_12(base.GetCppThis());
		}

		// Token: 0x0601BAAE RID: 113326
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMRDataIterator_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAAF RID: 113327 RVA: 0x0026BA64 File Offset: 0x00269C64
		public new static int IsTypeOf(string type)
		{
			return vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_IsTypeOf_13(type);
		}

		// Token: 0x0601BAB0 RID: 113328
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRDataIterator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAB1 RID: 113329 RVA: 0x0026BA80 File Offset: 0x00269C80
		public new vtkUniformGridAMRDataIterator NewInstance()
		{
			vtkUniformGridAMRDataIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGridAMRDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BAB2 RID: 113330
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRDataIterator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAB3 RID: 113331 RVA: 0x0026BADC File Offset: 0x00269CDC
		public new static vtkUniformGridAMRDataIterator SafeDownCast(vtkObjectBase o)
		{
			vtkUniformGridAMRDataIterator vtkUniformGridAMRDataIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRDataIterator.vtkUniformGridAMRDataIterator_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGridAMRDataIterator = (vtkUniformGridAMRDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGridAMRDataIterator.Register(null);
				}
			}
			return vtkUniformGridAMRDataIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA4 RID: 7588
		public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGridAMRDataIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA5 RID: 7589
		public new static readonly string MRClassNameKey = "class vtkUniformGridAMRDataIterator";
	}
}
