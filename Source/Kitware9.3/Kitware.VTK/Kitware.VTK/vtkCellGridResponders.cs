using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridResponders
	/// </summary>
	/// <remarks>
	///    A container that holds objects able to respond to queries
	///          specialized for particular vtkCellMetadata types.
	///
	/// This class holds sets of responders for vtkCellGridQuery and for
	/// vtkCellAttributeQuery.
	///
	/// ## Cell-grid query responders
	///
	/// vtkCellGridResponders holds a list of objects statically registered to
	/// the vtkCellMetadata subclass. These objects respond to
	/// queries for information (e.g., a bounding box) or processing
	/// (e.g., rendering, picking, generating isocontours) for one cell
	/// type (and subclasses of that cell type if no more specific
	/// responder is registered).
	///
	/// Application code (such as a plugin) can register subclasses of
	/// vtkCellGridResponse which accept the API of a particular
	/// vtkCellGridQuery for that cell type.
	/// Then, when a query is passed to the cell, this collection will
	/// identify matching responders for the query and invoke them until
	/// one returns true (indicating success).
	/// Multiple matches can exist as a responder can be registered to a
	/// common base cell class and/or to handle common base query classes.
	///
	/// If a given cell type cannot respond to a query, its superclasses
	/// are asked to respond. If no superclass can respond to the query,
	/// then query's superclasses are searched for responders.
	///
	/// Because queries can be registered to cell types at any time,
	/// existing cell types can be extended to support new features
	/// by additional libraries.
	///
	/// ## Cell-attribute calculators
	///
	/// In order to support the evaluation of vtkCellAttribute data
	/// on any vtkCellMetadata (cell type), this class also holds
	/// "calculators" grouped by both attribute and cell type.
	/// This API is different that vtkCellGridQuery because
	/// vtkCellAttribute is not subclassed by attribute type but
	/// rather uses vtkStringToken data to determine the nature of the
	/// attribute (e.g., Lagrange; Nedelec; Raviart-Thomas; etc.).
	///
	/// It is also different in that these objects are expected to be
	/// used inside vtkCellGridQuery to evaluate a single cell at a
	/// time rather than longer-running queries across all cells.
	///
	/// </remarks>
	/// <seealso>
	///  vtkCellMetadata vtkCellGrid vtkCellAttribute
	/// </seealso>
	// Token: 0x02000A23 RID: 2595
	public class vtkCellGridResponders : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B0CC RID: 110796 RVA: 0x0025C0D3 File Offset: 0x0025A2D3
		static vtkCellGridResponders()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridResponders.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridResponders"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B0CD RID: 110797 RVA: 0x0025C0FB File Offset: 0x0025A2FB
		public vtkCellGridResponders(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B0CE RID: 110798
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridResponders_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0CF RID: 110799 RVA: 0x0025C10C File Offset: 0x0025A30C
		public new static vtkCellGridResponders New()
		{
			vtkCellGridResponders result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridResponders.vtkCellGridResponders_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridResponders)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0D0 RID: 110800 RVA: 0x0025C160 File Offset: 0x0025A360
		public vtkCellGridResponders() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridResponders.vtkCellGridResponders_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B0D1 RID: 110801 RVA: 0x0025C1A4 File Offset: 0x0025A3A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B0D2 RID: 110802
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridResponders_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0D3 RID: 110803 RVA: 0x0025C1B0 File Offset: 0x0025A3B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridResponders.vtkCellGridResponders_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601B0D4 RID: 110804
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridResponders_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0D5 RID: 110805 RVA: 0x0025C1D0 File Offset: 0x0025A3D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridResponders.vtkCellGridResponders_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601B0D6 RID: 110806
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridResponders_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0D7 RID: 110807 RVA: 0x0025C1EC File Offset: 0x0025A3EC
		public override int IsA(string type)
		{
			return vtkCellGridResponders.vtkCellGridResponders_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601B0D8 RID: 110808
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridResponders_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0D9 RID: 110809 RVA: 0x0025C20C File Offset: 0x0025A40C
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridResponders.vtkCellGridResponders_IsTypeOf_04(type);
		}

		// Token: 0x0601B0DA RID: 110810
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridResponders_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0DB RID: 110811 RVA: 0x0025C228 File Offset: 0x0025A428
		public new vtkCellGridResponders NewInstance()
		{
			vtkCellGridResponders result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridResponders.vtkCellGridResponders_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridResponders)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B0DC RID: 110812
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGridResponders_Query_07(HandleRef pThis, HandleRef cellType, HandleRef query);

		/// <summary>
		/// Invoke a responder for the given query and cell type.
		///
		/// If none exists, return false.
		/// </summary>
		// Token: 0x0601B0DD RID: 110813 RVA: 0x0025C284 File Offset: 0x0025A484
		public bool Query(vtkCellMetadata cellType, vtkCellGridQuery query)
		{
			return vtkCellGridResponders.vtkCellGridResponders_Query_07(base.GetCppThis(), (cellType == null) ? default(HandleRef) : cellType.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis()) != 0;
		}

		// Token: 0x0601B0DE RID: 110814
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridResponders_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B0DF RID: 110815 RVA: 0x0025C2D4 File Offset: 0x0025A4D4
		public new static vtkCellGridResponders SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridResponders vtkCellGridResponders = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridResponders.vtkCellGridResponders_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D38 RID: 7480
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridResponders";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D39 RID: 7481
		public new static readonly string MRClassNameKey = "class vtkCellGridResponders";
	}
}
