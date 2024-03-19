using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphEdge
	/// </summary>
	/// <remarks>
	///    Representation of a single graph edge.
	///
	///
	/// A heavy-weight (vtkObject subclass) graph edge object that may be used
	/// instead of the vtkEdgeType struct, for use with wrappers.
	/// The edge contains the source and target vertex ids, and the edge id.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGraph
	/// </seealso>
	// Token: 0x02000A54 RID: 2644
	public class vtkGraphEdge : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B9CE RID: 113102 RVA: 0x0026A584 File Offset: 0x00268784
		static vtkGraphEdge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphEdge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphEdge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B9CF RID: 113103 RVA: 0x0026A5AC File Offset: 0x002687AC
		public vtkGraphEdge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B9D0 RID: 113104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphEdge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9D1 RID: 113105 RVA: 0x0026A5BC File Offset: 0x002687BC
		public new static vtkGraphEdge New()
		{
			vtkGraphEdge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphEdge.vtkGraphEdge_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9D2 RID: 113106 RVA: 0x0026A610 File Offset: 0x00268810
		public vtkGraphEdge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphEdge.vtkGraphEdge_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B9D3 RID: 113107 RVA: 0x0026A654 File Offset: 0x00268854
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B9D4 RID: 113108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphEdge_GetId_01(HandleRef pThis);

		/// <summary>
		/// The id of the edge.
		/// </summary>
		// Token: 0x0601B9D5 RID: 113109 RVA: 0x0026A660 File Offset: 0x00268860
		public virtual long GetId()
		{
			return vtkGraphEdge.vtkGraphEdge_GetId_01(base.GetCppThis());
		}

		// Token: 0x0601B9D6 RID: 113110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphEdge_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9D7 RID: 113111 RVA: 0x0026A680 File Offset: 0x00268880
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphEdge.vtkGraphEdge_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601B9D8 RID: 113112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphEdge_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9D9 RID: 113113 RVA: 0x0026A6A0 File Offset: 0x002688A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphEdge.vtkGraphEdge_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601B9DA RID: 113114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphEdge_GetSource_04(HandleRef pThis);

		/// <summary>
		/// The source of the edge.
		/// </summary>
		// Token: 0x0601B9DB RID: 113115 RVA: 0x0026A6BC File Offset: 0x002688BC
		public virtual long GetSource()
		{
			return vtkGraphEdge.vtkGraphEdge_GetSource_04(base.GetCppThis());
		}

		// Token: 0x0601B9DC RID: 113116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphEdge_GetTarget_05(HandleRef pThis);

		/// <summary>
		/// The target of the edge.
		/// </summary>
		// Token: 0x0601B9DD RID: 113117 RVA: 0x0026A6DC File Offset: 0x002688DC
		public virtual long GetTarget()
		{
			return vtkGraphEdge.vtkGraphEdge_GetTarget_05(base.GetCppThis());
		}

		// Token: 0x0601B9DE RID: 113118
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphEdge_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9DF RID: 113119 RVA: 0x0026A6FC File Offset: 0x002688FC
		public override int IsA(string type)
		{
			return vtkGraphEdge.vtkGraphEdge_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B9E0 RID: 113120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphEdge_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9E1 RID: 113121 RVA: 0x0026A71C File Offset: 0x0026891C
		public new static int IsTypeOf(string type)
		{
			return vtkGraphEdge.vtkGraphEdge_IsTypeOf_07(type);
		}

		// Token: 0x0601B9E2 RID: 113122
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphEdge_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9E3 RID: 113123 RVA: 0x0026A738 File Offset: 0x00268938
		public new vtkGraphEdge NewInstance()
		{
			vtkGraphEdge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphEdge.vtkGraphEdge_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B9E4 RID: 113124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphEdge_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9E5 RID: 113125 RVA: 0x0026A794 File Offset: 0x00268994
		public new static vtkGraphEdge SafeDownCast(vtkObjectBase o)
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphEdge.vtkGraphEdge_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphEdge = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphEdge.Register(null);
				}
			}
			return vtkGraphEdge;
		}

		// Token: 0x0601B9E6 RID: 113126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphEdge_SetId_11(HandleRef pThis, long _arg);

		/// <summary>
		/// The id of the edge.
		/// </summary>
		// Token: 0x0601B9E7 RID: 113127 RVA: 0x0026A813 File Offset: 0x00268A13
		public virtual void SetId(long _arg)
		{
			vtkGraphEdge.vtkGraphEdge_SetId_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B9E8 RID: 113128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphEdge_SetSource_12(HandleRef pThis, long _arg);

		/// <summary>
		/// The source of the edge.
		/// </summary>
		// Token: 0x0601B9E9 RID: 113129 RVA: 0x0026A823 File Offset: 0x00268A23
		public virtual void SetSource(long _arg)
		{
			vtkGraphEdge.vtkGraphEdge_SetSource_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B9EA RID: 113130
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphEdge_SetTarget_13(HandleRef pThis, long _arg);

		/// <summary>
		/// The target of the edge.
		/// </summary>
		// Token: 0x0601B9EB RID: 113131 RVA: 0x0026A833 File Offset: 0x00268A33
		public virtual void SetTarget(long _arg)
		{
			vtkGraphEdge.vtkGraphEdge_SetTarget_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D9C RID: 7580
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphEdge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D9D RID: 7581
		public new static readonly string MRClassNameKey = "class vtkGraphEdge";
	}
}
