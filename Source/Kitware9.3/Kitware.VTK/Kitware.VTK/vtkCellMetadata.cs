using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellMetadata
	/// </summary>
	/// <remarks>
	///    Metadata for a particular type of cell (finite element).
	///
	/// This is a base class for metadata on cell types held by a vtkCellGrid
	/// instance (not for subclasses of vtkCell).
	/// A vtkCellGrid holds one instance of a vtkCellMetadata-subclass for
	/// each *type* of cell present in the grid.
	///
	/// This class intentionally provides very little functionality; instead,
	/// it is intended to serve as a key or index into a set of registered
	/// responder classes which are able respond to queries about cells of
	/// this type. This pattern makes it possible to extend VTK with both
	/// new cell types and new types of queries for existing cell types.
	///
	/// </remarks>
	/// <seealso>
	///  vtkCellGrid
	/// </seealso>
	// Token: 0x020004DC RID: 1244
	public class vtkCellMetadata : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E16C RID: 57708 RVA: 0x001392AB File Offset: 0x001374AB
		static vtkCellMetadata()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellMetadata.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellMetadata"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E16D RID: 57709 RVA: 0x001392D3 File Offset: 0x001374D3
		public vtkCellMetadata(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E16E RID: 57710 RVA: 0x001392E1 File Offset: 0x001374E1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E16F RID: 57711
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellMetadata_DeepCopy_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Copy \a other into this instance (which must be of the same type).
		///
		/// These methods exist so subclasses know when they are being copied;
		/// the base class has no data to copy, so both ShallowCopy and DeepCopy
		/// do nothing.
		/// </summary>
		// Token: 0x0600E170 RID: 57712 RVA: 0x001392EC File Offset: 0x001374EC
		public virtual void DeepCopy(vtkCellMetadata arg0)
		{
			vtkCellMetadata.vtkCellMetadata_DeepCopy_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E171 RID: 57713
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellMetadata_GetCaches_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Copy \a other into this instance (which must be of the same type).
		///
		/// These methods exist so subclasses know when they are being copied;
		/// the base class has no data to copy, so both ShallowCopy and DeepCopy
		/// do nothing.
		/// </summary>
		// Token: 0x0600E172 RID: 57714 RVA: 0x0013931C File Offset: 0x0013751C
		public vtkCellGridResponders GetCaches()
		{
			vtkCellGridResponders vtkCellGridResponders = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellMetadata.vtkCellMetadata_GetCaches_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridResponders = (vtkCellGridResponders)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridResponders.Register(null);
				}
			}
			return vtkCellGridResponders;
		}

		// Token: 0x0600E173 RID: 57715
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellMetadata_GetCellGrid_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the vtkCellGrid holding DOF arrays required by this cell.
		///
		/// If the given vtkCellGrid does not have the required degrees
		/// of freedom arrays (as provided by GetDOFTypes()), then this
		/// method will return false.
		///
		/// If this method returns true, the \a parent grid will have
		/// incremented the reference count of \a this class instance.
		/// </summary>
		// Token: 0x0600E174 RID: 57716 RVA: 0x0013938C File Offset: 0x0013758C
		public virtual vtkCellGrid GetCellGrid()
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellMetadata.vtkCellMetadata_GetCellGrid_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x0600E175 RID: 57717
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellMetadata_GetNumberOfCells_04(HandleRef pThis);

		/// <summary>
		/// Set the vtkCellGrid holding DOF arrays required by this cell.
		///
		/// If the given vtkCellGrid does not have the required degrees
		/// of freedom arrays (as provided by GetDOFTypes()), then this
		/// method will return false.
		///
		/// If this method returns true, the \a parent grid will have
		/// incremented the reference count of \a this class instance.
		/// </summary>
		// Token: 0x0600E176 RID: 57718 RVA: 0x001393FC File Offset: 0x001375FC
		public virtual long GetNumberOfCells()
		{
			return vtkCellMetadata.vtkCellMetadata_GetNumberOfCells_04(base.GetCppThis());
		}

		// Token: 0x0600E177 RID: 57719
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellMetadata_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E178 RID: 57720 RVA: 0x0013941C File Offset: 0x0013761C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellMetadata.vtkCellMetadata_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E179 RID: 57721
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellMetadata_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E17A RID: 57722 RVA: 0x0013943C File Offset: 0x0013763C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellMetadata.vtkCellMetadata_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600E17B RID: 57723
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellMetadata_GetResponders_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Copy \a other into this instance (which must be of the same type).
		///
		/// These methods exist so subclasses know when they are being copied;
		/// the base class has no data to copy, so both ShallowCopy and DeepCopy
		/// do nothing.
		/// </summary>
		// Token: 0x0600E17C RID: 57724 RVA: 0x00139458 File Offset: 0x00137658
		public static vtkCellGridResponders GetResponders()
		{
			vtkCellGridResponders vtkCellGridResponders = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellMetadata.vtkCellMetadata_GetResponders_07(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridResponders = (vtkCellGridResponders)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridResponders.Register(null);
				}
			}
			return vtkCellGridResponders;
		}

		// Token: 0x0600E17D RID: 57725
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCellMetadata_Hash_08(HandleRef pThis);

		/// <summary>
		/// Return a hash of the cell type.
		///
		/// WARNING: If you change this method, you must also update
		/// vtkCellGrid::AddCellMetadata() and vtkCellGrid::GetCellsOfType().
		/// </summary>
		// Token: 0x0600E17E RID: 57726 RVA: 0x001394C4 File Offset: 0x001376C4
		public uint Hash()
		{
			return vtkCellMetadata.vtkCellMetadata_Hash_08(base.GetCppThis());
		}

		// Token: 0x0600E17F RID: 57727
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellMetadata_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E180 RID: 57728 RVA: 0x001394E4 File Offset: 0x001376E4
		public override int IsA(string type)
		{
			return vtkCellMetadata.vtkCellMetadata_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600E181 RID: 57729
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellMetadata_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E182 RID: 57730 RVA: 0x00139504 File Offset: 0x00137704
		public new static int IsTypeOf(string type)
		{
			return vtkCellMetadata.vtkCellMetadata_IsTypeOf_10(type);
		}

		// Token: 0x0600E183 RID: 57731
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellMetadata_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E184 RID: 57732 RVA: 0x00139520 File Offset: 0x00137720
		public new vtkCellMetadata NewInstance()
		{
			vtkCellMetadata result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellMetadata.vtkCellMetadata_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellMetadata)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E185 RID: 57733
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellMetadata_Query_12(HandleRef pThis, HandleRef query);

		/// <summary>
		/// Respond to a query on cells of this type.
		///
		/// This returns true on success and false on failure.
		/// If no responder has been registered for queries of this type,
		/// that is considered a failure.
		/// </summary>
		// Token: 0x0600E186 RID: 57734 RVA: 0x0013957C File Offset: 0x0013777C
		public bool Query(vtkCellGridQuery query)
		{
			return vtkCellMetadata.vtkCellMetadata_Query_12(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis()) != 0;
		}

		// Token: 0x0600E187 RID: 57735
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellMetadata_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E188 RID: 57736 RVA: 0x001395B8 File Offset: 0x001377B8
		public new static vtkCellMetadata SafeDownCast(vtkObjectBase o)
		{
			vtkCellMetadata vtkCellMetadata = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellMetadata.vtkCellMetadata_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellMetadata = (vtkCellMetadata)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellMetadata.Register(null);
				}
			}
			return vtkCellMetadata;
		}

		// Token: 0x0600E189 RID: 57737
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellMetadata_SetCellGrid_14(HandleRef pThis, HandleRef parent);

		/// <summary>
		/// Set the vtkCellGrid holding DOF arrays required by this cell.
		///
		/// If the given vtkCellGrid does not have the required degrees
		/// of freedom arrays (as provided by GetDOFTypes()), then this
		/// method will return false.
		///
		/// If this method returns true, the \a parent grid will have
		/// incremented the reference count of \a this class instance.
		/// </summary>
		// Token: 0x0600E18A RID: 57738 RVA: 0x00139638 File Offset: 0x00137838
		public virtual bool SetCellGrid(vtkCellGrid parent)
		{
			return vtkCellMetadata.vtkCellMetadata_SetCellGrid_14(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis()) != 0;
		}

		// Token: 0x0600E18B RID: 57739
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellMetadata_ShallowCopy_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Copy \a other into this instance (which must be of the same type).
		///
		/// These methods exist so subclasses know when they are being copied;
		/// the base class has no data to copy, so both ShallowCopy and DeepCopy
		/// do nothing.
		/// </summary>
		// Token: 0x0600E18C RID: 57740 RVA: 0x00139674 File Offset: 0x00137874
		public virtual void ShallowCopy(vtkCellMetadata arg0)
		{
			vtkCellMetadata.vtkCellMetadata_ShallowCopy_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001093 RID: 4243
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellMetadata";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001094 RID: 4244
		public new static readonly string MRClassNameKey = "class vtkCellMetadata";
	}
}
