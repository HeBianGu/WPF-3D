using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiPieceDataSet
	/// </summary>
	/// <remarks>
	///    composite dataset to encapsulates pieces of
	/// dataset.
	///
	/// A vtkMultiPieceDataSet dataset groups multiple data pieces together.
	/// For example, say that a simulation broke a volume into 16 piece so that
	/// each piece can be processed with 1 process in parallel. We want to load
	/// this volume in a visualization cluster of 4 nodes. Each node will get 4
	/// pieces, not necessarily forming a whole rectangular piece. In this case,
	/// it is not possible to append the 4 pieces together into a vtkImageData.
	/// In this case, these 4 pieces can be collected together using a
	/// vtkMultiPieceDataSet.
	/// Note that vtkMultiPieceDataSet is intended to be included in other composite
	/// datasets eg. vtkMultiBlockDataSet, vtkHierarchicalBoxDataSet. Hence the lack
	/// of algorithms producing vtkMultiPieceDataSet.
	/// </remarks>
	// Token: 0x02000A86 RID: 2694
	public class vtkMultiPieceDataSet : vtkPartitionedDataSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C378 RID: 115576 RVA: 0x00279DDC File Offset: 0x00277FDC
		static vtkMultiPieceDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiPieceDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiPieceDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C379 RID: 115577 RVA: 0x00279E04 File Offset: 0x00278004
		public vtkMultiPieceDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C37A RID: 115578
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiPieceDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C37B RID: 115579 RVA: 0x00279E14 File Offset: 0x00278014
		public new static vtkMultiPieceDataSet New()
		{
			vtkMultiPieceDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C37C RID: 115580 RVA: 0x00279E68 File Offset: 0x00278068
		public vtkMultiPieceDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiPieceDataSet.vtkMultiPieceDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C37D RID: 115581 RVA: 0x00279EAC File Offset: 0x002780AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C37E RID: 115582
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiPieceDataSet_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C37F RID: 115583 RVA: 0x00279EB8 File Offset: 0x002780B8
		public new static vtkMultiPieceDataSet GetData(vtkInformation info)
		{
			vtkMultiPieceDataSet vtkMultiPieceDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiPieceDataSet = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiPieceDataSet.Register(null);
				}
			}
			return vtkMultiPieceDataSet;
		}

		// Token: 0x0601C380 RID: 115584
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiPieceDataSet_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C381 RID: 115585 RVA: 0x00279F38 File Offset: 0x00278138
		public new static vtkMultiPieceDataSet GetData(vtkInformationVector v, int i)
		{
			vtkMultiPieceDataSet vtkMultiPieceDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiPieceDataSet = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiPieceDataSet.Register(null);
				}
			}
			return vtkMultiPieceDataSet;
		}

		// Token: 0x0601C382 RID: 115586
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiPieceDataSet_GetDataObjectType_03(HandleRef pThis);

		/// <summary>
		/// Return class name of data type (see vtkType.h for
		/// definitions).
		/// </summary>
		// Token: 0x0601C383 RID: 115587 RVA: 0x00279FB8 File Offset: 0x002781B8
		public override int GetDataObjectType()
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetDataObjectType_03(base.GetCppThis());
		}

		// Token: 0x0601C384 RID: 115588
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiPieceDataSet_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C385 RID: 115589 RVA: 0x00279FD8 File Offset: 0x002781D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C386 RID: 115590
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiPieceDataSet_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C387 RID: 115591 RVA: 0x00279FF8 File Offset: 0x002781F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601C388 RID: 115592
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkMultiPieceDataSet_GetNumberOfPieces_06(HandleRef pThis);

		/// <summary>
		/// Returns the number of pieces.
		/// </summary>
		// Token: 0x0601C389 RID: 115593 RVA: 0x0027A014 File Offset: 0x00278214
		public uint GetNumberOfPieces()
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetNumberOfPieces_06(base.GetCppThis());
		}

		// Token: 0x0601C38A RID: 115594
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiPieceDataSet_GetPiece_07(HandleRef pThis, uint pieceno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the piece at the given index.
		/// </summary>
		// Token: 0x0601C38B RID: 115595 RVA: 0x0027A034 File Offset: 0x00278234
		public vtkDataSet GetPiece(uint pieceno)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetPiece_07(base.GetCppThis(), pieceno, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601C38C RID: 115596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiPieceDataSet_GetPieceAsDataObject_08(HandleRef pThis, uint pieceno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the piece at the given index.
		/// </summary>
		// Token: 0x0601C38D RID: 115597 RVA: 0x0027A0A4 File Offset: 0x002782A4
		public vtkDataObject GetPieceAsDataObject(uint pieceno)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetPieceAsDataObject_08(base.GetCppThis(), pieceno, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C38E RID: 115598
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiPieceDataSet_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C38F RID: 115599 RVA: 0x0027A114 File Offset: 0x00278314
		public override int IsA(string type)
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601C390 RID: 115600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiPieceDataSet_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C391 RID: 115601 RVA: 0x0027A134 File Offset: 0x00278334
		public new static int IsTypeOf(string type)
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_IsTypeOf_10(type);
		}

		// Token: 0x0601C392 RID: 115602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiPieceDataSet_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C393 RID: 115603 RVA: 0x0027A150 File Offset: 0x00278350
		public new vtkMultiPieceDataSet NewInstance()
		{
			vtkMultiPieceDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C394 RID: 115604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiPieceDataSet_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C395 RID: 115605 RVA: 0x0027A1AC File Offset: 0x002783AC
		public new static vtkMultiPieceDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkMultiPieceDataSet vtkMultiPieceDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiPieceDataSet = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiPieceDataSet.Register(null);
				}
			}
			return vtkMultiPieceDataSet;
		}

		// Token: 0x0601C396 RID: 115606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiPieceDataSet_SetNumberOfPieces_14(HandleRef pThis, uint numpieces);

		/// <summary>
		/// Set the number of pieces. This will cause allocation if the new number of
		/// pieces is greater than the current size. All new pieces are initialized to
		/// null.
		/// </summary>
		// Token: 0x0601C397 RID: 115607 RVA: 0x0027A22B File Offset: 0x0027842B
		public void SetNumberOfPieces(uint numpieces)
		{
			vtkMultiPieceDataSet.vtkMultiPieceDataSet_SetNumberOfPieces_14(base.GetCppThis(), numpieces);
		}

		// Token: 0x0601C398 RID: 115608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiPieceDataSet_SetPiece_15(HandleRef pThis, uint pieceno, HandleRef piece);

		/// <summary>
		/// Sets the data object as the given piece. The total number of pieces will
		/// be resized to fit the requested piece no.
		/// </summary>
		// Token: 0x0601C399 RID: 115609 RVA: 0x0027A23C File Offset: 0x0027843C
		public void SetPiece(uint pieceno, vtkDataObject piece)
		{
			vtkMultiPieceDataSet.vtkMultiPieceDataSet_SetPiece_15(base.GetCppThis(), pieceno, (piece == null) ? default(HandleRef) : piece.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E08 RID: 7688
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiPieceDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E09 RID: 7689
		public new static readonly string MRClassNameKey = "class vtkMultiPieceDataSet";
	}
}
