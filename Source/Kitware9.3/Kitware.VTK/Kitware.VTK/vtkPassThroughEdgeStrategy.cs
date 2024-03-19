using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPassThroughEdgeStrategy
	/// </summary>
	/// <remarks>
	///    passes edge routing information through
	///
	///
	/// Simply passes existing edge layout information from the input to the
	/// output without making changes.
	/// </remarks>
	// Token: 0x02000294 RID: 660
	public class vtkPassThroughEdgeStrategy : vtkEdgeLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007794 RID: 30612 RVA: 0x000AC6E3 File Offset: 0x000AA8E3
		static vtkPassThroughEdgeStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassThroughEdgeStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassThroughEdgeStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007795 RID: 30613 RVA: 0x000AC70B File Offset: 0x000AA90B
		public vtkPassThroughEdgeStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007796 RID: 30614
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassThroughEdgeStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007797 RID: 30615 RVA: 0x000AC71C File Offset: 0x000AA91C
		public new static vtkPassThroughEdgeStrategy New()
		{
			vtkPassThroughEdgeStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThroughEdgeStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007798 RID: 30616 RVA: 0x000AC770 File Offset: 0x000AA970
		public vtkPassThroughEdgeStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007799 RID: 30617 RVA: 0x000AC7B4 File Offset: 0x000AA9B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600779A RID: 30618
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassThroughEdgeStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600779B RID: 30619 RVA: 0x000AC7C0 File Offset: 0x000AA9C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600779C RID: 30620
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassThroughEdgeStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600779D RID: 30621 RVA: 0x000AC7E0 File Offset: 0x000AA9E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600779E RID: 30622
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassThroughEdgeStrategy_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600779F RID: 30623 RVA: 0x000AC7FC File Offset: 0x000AA9FC
		public override int IsA(string type)
		{
			return vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060077A0 RID: 30624
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassThroughEdgeStrategy_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077A1 RID: 30625 RVA: 0x000AC81C File Offset: 0x000AAA1C
		public new static int IsTypeOf(string type)
		{
			return vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_IsTypeOf_04(type);
		}

		// Token: 0x060077A2 RID: 30626
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassThroughEdgeStrategy_Layout_05(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out.
		/// </summary>
		// Token: 0x060077A3 RID: 30627 RVA: 0x000AC836 File Offset: 0x000AAA36
		public override void Layout()
		{
			vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_Layout_05(base.GetCppThis());
		}

		// Token: 0x060077A4 RID: 30628
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassThroughEdgeStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077A5 RID: 30629 RVA: 0x000AC848 File Offset: 0x000AAA48
		public new vtkPassThroughEdgeStrategy NewInstance()
		{
			vtkPassThroughEdgeStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThroughEdgeStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060077A6 RID: 30630
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassThroughEdgeStrategy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077A7 RID: 30631 RVA: 0x000AC8A4 File Offset: 0x000AAAA4
		public new static vtkPassThroughEdgeStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkPassThroughEdgeStrategy vtkPassThroughEdgeStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassThroughEdgeStrategy.vtkPassThroughEdgeStrategy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassThroughEdgeStrategy = (vtkPassThroughEdgeStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassThroughEdgeStrategy.Register(null);
				}
			}
			return vtkPassThroughEdgeStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A36 RID: 2614
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassThroughEdgeStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A37 RID: 2615
		public new static readonly string MRClassNameKey = "class vtkPassThroughEdgeStrategy";
	}
}
