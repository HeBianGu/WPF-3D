using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPassThroughLayoutStrategy
	/// </summary>
	/// <remarks>
	///    a layout strategy that does absolutely nothing
	///
	///
	/// Yes, this incredible strategy does absoluted nothing to the data
	/// so in affect passes through the graph untouched. This strategy
	/// is useful in the cases where the graph is already laid out.
	/// </remarks>
	// Token: 0x02000295 RID: 661
	public class vtkPassThroughLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060077A8 RID: 30632 RVA: 0x000AC923 File Offset: 0x000AAB23
		static vtkPassThroughLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassThroughLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassThroughLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060077A9 RID: 30633 RVA: 0x000AC94B File Offset: 0x000AAB4B
		public vtkPassThroughLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060077AA RID: 30634
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassThroughLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077AB RID: 30635 RVA: 0x000AC95C File Offset: 0x000AAB5C
		public new static vtkPassThroughLayoutStrategy New()
		{
			vtkPassThroughLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThroughLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077AC RID: 30636 RVA: 0x000AC9B0 File Offset: 0x000AABB0
		public vtkPassThroughLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060077AD RID: 30637 RVA: 0x000AC9F4 File Offset: 0x000AABF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060077AE RID: 30638
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassThroughLayoutStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077AF RID: 30639 RVA: 0x000ACA00 File Offset: 0x000AAC00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060077B0 RID: 30640
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassThroughLayoutStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077B1 RID: 30641 RVA: 0x000ACA20 File Offset: 0x000AAC20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060077B2 RID: 30642
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassThroughLayoutStrategy_Initialize_03(HandleRef pThis);

		/// <summary>
		/// This strategy sets up some data structures
		/// for faster processing of each Layout() call
		/// </summary>
		// Token: 0x060077B3 RID: 30643 RVA: 0x000ACA3A File Offset: 0x000AAC3A
		public override void Initialize()
		{
			vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_Initialize_03(base.GetCppThis());
		}

		// Token: 0x060077B4 RID: 30644
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassThroughLayoutStrategy_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077B5 RID: 30645 RVA: 0x000ACA4C File Offset: 0x000AAC4C
		public override int IsA(string type)
		{
			return vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060077B6 RID: 30646
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassThroughLayoutStrategy_IsLayoutComplete_05(HandleRef pThis);

		/// <summary>
		/// I'm an iterative layout so this method lets the caller
		/// know if I'm done laying out the graph
		/// </summary>
		// Token: 0x060077B7 RID: 30647 RVA: 0x000ACA6C File Offset: 0x000AAC6C
		public override int IsLayoutComplete()
		{
			return vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_IsLayoutComplete_05(base.GetCppThis());
		}

		// Token: 0x060077B8 RID: 30648
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassThroughLayoutStrategy_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077B9 RID: 30649 RVA: 0x000ACA8C File Offset: 0x000AAC8C
		public new static int IsTypeOf(string type)
		{
			return vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_IsTypeOf_06(type);
		}

		// Token: 0x060077BA RID: 30650
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassThroughLayoutStrategy_Layout_07(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out. The method can either
		/// entirely layout the graph or iteratively lay out the
		/// graph. If you have an iterative layout please implement
		/// the IsLayoutComplete() method.
		/// </summary>
		// Token: 0x060077BB RID: 30651 RVA: 0x000ACAA6 File Offset: 0x000AACA6
		public override void Layout()
		{
			vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_Layout_07(base.GetCppThis());
		}

		// Token: 0x060077BC RID: 30652
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassThroughLayoutStrategy_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077BD RID: 30653 RVA: 0x000ACAB8 File Offset: 0x000AACB8
		public new vtkPassThroughLayoutStrategy NewInstance()
		{
			vtkPassThroughLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThroughLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060077BE RID: 30654
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassThroughLayoutStrategy_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077BF RID: 30655 RVA: 0x000ACB14 File Offset: 0x000AAD14
		public new static vtkPassThroughLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkPassThroughLayoutStrategy vtkPassThroughLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassThroughLayoutStrategy.vtkPassThroughLayoutStrategy_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassThroughLayoutStrategy = (vtkPassThroughLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassThroughLayoutStrategy.Register(null);
				}
			}
			return vtkPassThroughLayoutStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A38 RID: 2616
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassThroughLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A39 RID: 2617
		public new static readonly string MRClassNameKey = "class vtkPassThroughLayoutStrategy";
	}
}
