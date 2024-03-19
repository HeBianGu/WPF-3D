using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEdgeLayout
	/// </summary>
	/// <remarks>
	///    layout graph edges
	///
	///
	/// This class is a shell for many edge layout strategies which may be set
	/// using the SetLayoutStrategy() function.  The layout strategies do the
	/// actual work.
	/// </remarks>
	// Token: 0x0200028C RID: 652
	public class vtkEdgeLayout : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060075FA RID: 30202 RVA: 0x000AA5C1 File Offset: 0x000A87C1
		static vtkEdgeLayout()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeLayout"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060075FB RID: 30203 RVA: 0x000AA5E9 File Offset: 0x000A87E9
		public vtkEdgeLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060075FC RID: 30204
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075FD RID: 30205 RVA: 0x000AA5F8 File Offset: 0x000A87F8
		public new static vtkEdgeLayout New()
		{
			vtkEdgeLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeLayout.vtkEdgeLayout_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075FE RID: 30206 RVA: 0x000AA64C File Offset: 0x000A884C
		public vtkEdgeLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEdgeLayout.vtkEdgeLayout_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060075FF RID: 30207 RVA: 0x000AA690 File Offset: 0x000A8890
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007600 RID: 30208
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeLayout_GetLayoutStrategy_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The layout strategy to use during graph layout.
		/// </summary>
		// Token: 0x06007601 RID: 30209 RVA: 0x000AA69C File Offset: 0x000A889C
		public virtual vtkEdgeLayoutStrategy GetLayoutStrategy()
		{
			vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeLayout.vtkEdgeLayout_GetLayoutStrategy_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeLayoutStrategy = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeLayoutStrategy.Register(null);
				}
			}
			return vtkEdgeLayoutStrategy;
		}

		// Token: 0x06007602 RID: 30210
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkEdgeLayout_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Get the modification time of the layout algorithm.
		/// </summary>
		// Token: 0x06007603 RID: 30211 RVA: 0x000AA70C File Offset: 0x000A890C
		public override ulong GetMTime()
		{
			return vtkEdgeLayout.vtkEdgeLayout_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x06007604 RID: 30212
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeLayout_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007605 RID: 30213 RVA: 0x000AA72C File Offset: 0x000A892C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEdgeLayout.vtkEdgeLayout_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06007606 RID: 30214
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeLayout_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007607 RID: 30215 RVA: 0x000AA74C File Offset: 0x000A894C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEdgeLayout.vtkEdgeLayout_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06007608 RID: 30216
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeLayout_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007609 RID: 30217 RVA: 0x000AA768 File Offset: 0x000A8968
		public override int IsA(string type)
		{
			return vtkEdgeLayout.vtkEdgeLayout_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600760A RID: 30218
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeLayout_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600760B RID: 30219 RVA: 0x000AA788 File Offset: 0x000A8988
		public new static int IsTypeOf(string type)
		{
			return vtkEdgeLayout.vtkEdgeLayout_IsTypeOf_06(type);
		}

		// Token: 0x0600760C RID: 30220
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeLayout_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600760D RID: 30221 RVA: 0x000AA7A4 File Offset: 0x000A89A4
		public new vtkEdgeLayout NewInstance()
		{
			vtkEdgeLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeLayout.vtkEdgeLayout_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600760E RID: 30222
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeLayout_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600760F RID: 30223 RVA: 0x000AA800 File Offset: 0x000A8A00
		public new static vtkEdgeLayout SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeLayout vtkEdgeLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeLayout.vtkEdgeLayout_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeLayout = (vtkEdgeLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeLayout.Register(null);
				}
			}
			return vtkEdgeLayout;
		}

		// Token: 0x06007610 RID: 30224
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeLayout_SetLayoutStrategy_10(HandleRef pThis, HandleRef strategy);

		/// <summary>
		/// The layout strategy to use during graph layout.
		/// </summary>
		// Token: 0x06007611 RID: 30225 RVA: 0x000AA880 File Offset: 0x000A8A80
		public void SetLayoutStrategy(vtkEdgeLayoutStrategy strategy)
		{
			vtkEdgeLayout.vtkEdgeLayout_SetLayoutStrategy_10(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A26 RID: 2598
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeLayout";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A27 RID: 2599
		public new static readonly string MRClassNameKey = "class vtkEdgeLayout";
	}
}
