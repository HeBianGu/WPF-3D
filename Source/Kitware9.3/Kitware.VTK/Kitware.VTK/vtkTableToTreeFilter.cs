using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableToTreeFilter
	/// </summary>
	/// <remarks>
	///    Filter that converts a vtkTable to a vtkTree
	///
	///
	///
	/// vtkTableToTreeFilter is a filter for converting a vtkTable data structure
	/// into a vtkTree datastructure.  Currently, this will convert the table into
	/// a star, with each row of the table as a child of a new root node.
	/// The columns of the table are passed as node fields of the tree.
	/// </remarks>
	// Token: 0x02000697 RID: 1687
	public class vtkTableToTreeFilter : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012147 RID: 74055 RVA: 0x00194F83 File Offset: 0x00193183
		static vtkTableToTreeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToTreeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToTreeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012148 RID: 74056 RVA: 0x00194FAB File Offset: 0x001931AB
		public vtkTableToTreeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012149 RID: 74057
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToTreeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601214A RID: 74058 RVA: 0x00194FBC File Offset: 0x001931BC
		public new static vtkTableToTreeFilter New()
		{
			vtkTableToTreeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToTreeFilter.vtkTableToTreeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToTreeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601214B RID: 74059 RVA: 0x00195010 File Offset: 0x00193210
		public vtkTableToTreeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableToTreeFilter.vtkTableToTreeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601214C RID: 74060 RVA: 0x00195054 File Offset: 0x00193254
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601214D RID: 74061
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToTreeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601214E RID: 74062 RVA: 0x00195060 File Offset: 0x00193260
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableToTreeFilter.vtkTableToTreeFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601214F RID: 74063
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToTreeFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012150 RID: 74064 RVA: 0x00195080 File Offset: 0x00193280
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableToTreeFilter.vtkTableToTreeFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012151 RID: 74065
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToTreeFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012152 RID: 74066 RVA: 0x0019509C File Offset: 0x0019329C
		public override int IsA(string type)
		{
			return vtkTableToTreeFilter.vtkTableToTreeFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012153 RID: 74067
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToTreeFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012154 RID: 74068 RVA: 0x001950BC File Offset: 0x001932BC
		public new static int IsTypeOf(string type)
		{
			return vtkTableToTreeFilter.vtkTableToTreeFilter_IsTypeOf_04(type);
		}

		// Token: 0x06012155 RID: 74069
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToTreeFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012156 RID: 74070 RVA: 0x001950D8 File Offset: 0x001932D8
		public new vtkTableToTreeFilter NewInstance()
		{
			vtkTableToTreeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToTreeFilter.vtkTableToTreeFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToTreeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012157 RID: 74071
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToTreeFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012158 RID: 74072 RVA: 0x00195134 File Offset: 0x00193334
		public new static vtkTableToTreeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTableToTreeFilter vtkTableToTreeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToTreeFilter.vtkTableToTreeFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToTreeFilter = (vtkTableToTreeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToTreeFilter.Register(null);
				}
			}
			return vtkTableToTreeFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D9 RID: 5337
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToTreeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014DA RID: 5338
		public new static readonly string MRClassNameKey = "class vtkTableToTreeFilter";
	}
}
