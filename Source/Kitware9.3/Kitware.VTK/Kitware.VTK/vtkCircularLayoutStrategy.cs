using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCircularLayoutStrategy
	/// </summary>
	/// <remarks>
	///    Places vertices around a circle
	///
	///
	/// Assigns points to the vertices around a circle with unit radius.
	/// </remarks>
	// Token: 0x02000286 RID: 646
	public class vtkCircularLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060074BE RID: 29886 RVA: 0x000A8DDF File Offset: 0x000A6FDF
		static vtkCircularLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCircularLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCircularLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060074BF RID: 29887 RVA: 0x000A8E07 File Offset: 0x000A7007
		public vtkCircularLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060074C0 RID: 29888
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCircularLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074C1 RID: 29889 RVA: 0x000A8E18 File Offset: 0x000A7018
		public new static vtkCircularLayoutStrategy New()
		{
			vtkCircularLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCircularLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074C2 RID: 29890 RVA: 0x000A8E6C File Offset: 0x000A706C
		public vtkCircularLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060074C3 RID: 29891 RVA: 0x000A8EB0 File Offset: 0x000A70B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060074C4 RID: 29892
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCircularLayoutStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074C5 RID: 29893 RVA: 0x000A8EBC File Offset: 0x000A70BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060074C6 RID: 29894
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCircularLayoutStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074C7 RID: 29895 RVA: 0x000A8EDC File Offset: 0x000A70DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060074C8 RID: 29896
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCircularLayoutStrategy_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074C9 RID: 29897 RVA: 0x000A8EF8 File Offset: 0x000A70F8
		public override int IsA(string type)
		{
			return vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060074CA RID: 29898
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCircularLayoutStrategy_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074CB RID: 29899 RVA: 0x000A8F18 File Offset: 0x000A7118
		public new static int IsTypeOf(string type)
		{
			return vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_IsTypeOf_04(type);
		}

		// Token: 0x060074CC RID: 29900
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCircularLayoutStrategy_Layout_05(HandleRef pThis);

		/// <summary>
		/// Perform the layout.
		/// </summary>
		// Token: 0x060074CD RID: 29901 RVA: 0x000A8F32 File Offset: 0x000A7132
		public override void Layout()
		{
			vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_Layout_05(base.GetCppThis());
		}

		// Token: 0x060074CE RID: 29902
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCircularLayoutStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074CF RID: 29903 RVA: 0x000A8F44 File Offset: 0x000A7144
		public new vtkCircularLayoutStrategy NewInstance()
		{
			vtkCircularLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCircularLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060074D0 RID: 29904
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCircularLayoutStrategy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060074D1 RID: 29905 RVA: 0x000A8FA0 File Offset: 0x000A71A0
		public new static vtkCircularLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkCircularLayoutStrategy vtkCircularLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCircularLayoutStrategy.vtkCircularLayoutStrategy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCircularLayoutStrategy = (vtkCircularLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCircularLayoutStrategy.Register(null);
				}
			}
			return vtkCircularLayoutStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A1A RID: 2586
		public new const string MRFullTypeName = "Kitware.VTK.vtkCircularLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A1B RID: 2587
		public new static readonly string MRClassNameKey = "class vtkCircularLayoutStrategy";
	}
}
