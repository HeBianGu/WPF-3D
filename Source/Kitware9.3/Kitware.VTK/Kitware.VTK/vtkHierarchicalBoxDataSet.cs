using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalBoxDataSet
	/// </summary>
	/// <remarks>
	///    Backwards compatibility class
	///
	///
	/// An empty class for backwards compatibility
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUniformGridAM vtkOverlappingAMR vtkNonOverlappingAMR
	/// </seealso>
	// Token: 0x02000A5C RID: 2652
	public class vtkHierarchicalBoxDataSet : vtkOverlappingAMR
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BB50 RID: 113488 RVA: 0x0026CB75 File Offset: 0x0026AD75
		static vtkHierarchicalBoxDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalBoxDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalBoxDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BB51 RID: 113489 RVA: 0x0026CB9D File Offset: 0x0026AD9D
		public vtkHierarchicalBoxDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BB52 RID: 113490
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB53 RID: 113491 RVA: 0x0026CBAC File Offset: 0x0026ADAC
		public new static vtkHierarchicalBoxDataSet New()
		{
			vtkHierarchicalBoxDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB54 RID: 113492 RVA: 0x0026CC00 File Offset: 0x0026AE00
		public vtkHierarchicalBoxDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BB55 RID: 113493 RVA: 0x0026CC44 File Offset: 0x0026AE44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BB56 RID: 113494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601BB57 RID: 113495 RVA: 0x0026CC50 File Offset: 0x0026AE50
		public new static vtkHierarchicalBoxDataSet GetData(vtkInformation info)
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		// Token: 0x0601BB58 RID: 113496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601BB59 RID: 113497 RVA: 0x0026CCD0 File Offset: 0x0026AED0
		public new static vtkHierarchicalBoxDataSet GetData(vtkInformationVector v, int i)
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		// Token: 0x0601BB5A RID: 113498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBoxDataSet_GetDataObjectType_03(HandleRef pThis);

		/// <summary>
		/// Return class name of data type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601BB5B RID: 113499 RVA: 0x0026CD50 File Offset: 0x0026AF50
		public override int GetDataObjectType()
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetDataObjectType_03(base.GetCppThis());
		}

		// Token: 0x0601BB5C RID: 113500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBoxDataSet_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB5D RID: 113501 RVA: 0x0026CD70 File Offset: 0x0026AF70
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601BB5E RID: 113502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBoxDataSet_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB5F RID: 113503 RVA: 0x0026CD90 File Offset: 0x0026AF90
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601BB60 RID: 113504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBoxDataSet_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB61 RID: 113505 RVA: 0x0026CDAC File Offset: 0x0026AFAC
		public override int IsA(string type)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601BB62 RID: 113506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBoxDataSet_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB63 RID: 113507 RVA: 0x0026CDCC File Offset: 0x0026AFCC
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_IsTypeOf_07(type);
		}

		// Token: 0x0601BB64 RID: 113508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB65 RID: 113509 RVA: 0x0026CDE8 File Offset: 0x0026AFE8
		public new vtkHierarchicalBoxDataSet NewInstance()
		{
			vtkHierarchicalBoxDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BB66 RID: 113510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_NewIterator_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a new iterator (the iterator has to be deleted by user).
		/// </summary>
		// Token: 0x0601BB67 RID: 113511 RVA: 0x0026CE44 File Offset: 0x0026B044
		public override vtkCompositeDataIterator NewIterator()
		{
			vtkCompositeDataIterator vtkCompositeDataIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_NewIterator_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BB68 RID: 113512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB69 RID: 113513 RVA: 0x0026CEB4 File Offset: 0x0026B0B4
		public new static vtkHierarchicalBoxDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DAC RID: 7596
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalBoxDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DAD RID: 7597
		public new static readonly string MRClassNameKey = "class vtkHierarchicalBoxDataSet";
	}
}
