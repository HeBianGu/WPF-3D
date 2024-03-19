using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAssignCoordinatesLayoutStrategy
	/// </summary>
	/// <remarks>
	///    uses array values to set vertex locations
	///
	///
	/// Uses vtkAssignCoordinates to use values from arrays as the x, y, and z coordinates.
	/// </remarks>
	// Token: 0x0200027E RID: 638
	public class vtkAssignCoordinatesLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060073C8 RID: 29640 RVA: 0x000A762F File Offset: 0x000A582F
		static vtkAssignCoordinatesLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssignCoordinatesLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssignCoordinatesLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060073C9 RID: 29641 RVA: 0x000A7657 File Offset: 0x000A5857
		public vtkAssignCoordinatesLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060073CA RID: 29642
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073CB RID: 29643 RVA: 0x000A7668 File Offset: 0x000A5868
		public new static vtkAssignCoordinatesLayoutStrategy New()
		{
			vtkAssignCoordinatesLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignCoordinatesLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073CC RID: 29644 RVA: 0x000A76BC File Offset: 0x000A58BC
		public vtkAssignCoordinatesLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060073CD RID: 29645 RVA: 0x000A7700 File Offset: 0x000A5900
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060073CE RID: 29646
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssignCoordinatesLayoutStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073CF RID: 29647 RVA: 0x000A770C File Offset: 0x000A590C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060073D0 RID: 29648
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssignCoordinatesLayoutStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073D1 RID: 29649 RVA: 0x000A772C File Offset: 0x000A592C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060073D2 RID: 29650
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_GetXCoordArrayName_03(HandleRef pThis);

		/// <summary>
		/// The array to use for the x coordinate values.
		/// </summary>
		// Token: 0x060073D3 RID: 29651 RVA: 0x000A7748 File Offset: 0x000A5948
		public virtual string GetXCoordArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_GetXCoordArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060073D4 RID: 29652
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_GetYCoordArrayName_04(HandleRef pThis);

		/// <summary>
		/// The array to use for the y coordinate values.
		/// </summary>
		// Token: 0x060073D5 RID: 29653 RVA: 0x000A7784 File Offset: 0x000A5984
		public virtual string GetYCoordArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_GetYCoordArrayName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060073D6 RID: 29654
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_GetZCoordArrayName_05(HandleRef pThis);

		/// <summary>
		/// The array to use for the z coordinate values.
		/// </summary>
		// Token: 0x060073D7 RID: 29655 RVA: 0x000A77C0 File Offset: 0x000A59C0
		public virtual string GetZCoordArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_GetZCoordArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060073D8 RID: 29656
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssignCoordinatesLayoutStrategy_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073D9 RID: 29657 RVA: 0x000A77FC File Offset: 0x000A59FC
		public override int IsA(string type)
		{
			return vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060073DA RID: 29658
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssignCoordinatesLayoutStrategy_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073DB RID: 29659 RVA: 0x000A781C File Offset: 0x000A5A1C
		public new static int IsTypeOf(string type)
		{
			return vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_IsTypeOf_07(type);
		}

		// Token: 0x060073DC RID: 29660
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignCoordinatesLayoutStrategy_Layout_08(HandleRef pThis);

		/// <summary>
		/// Perform the random layout.
		/// </summary>
		// Token: 0x060073DD RID: 29661 RVA: 0x000A7836 File Offset: 0x000A5A36
		public override void Layout()
		{
			vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_Layout_08(base.GetCppThis());
		}

		// Token: 0x060073DE RID: 29662
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073DF RID: 29663 RVA: 0x000A7848 File Offset: 0x000A5A48
		public new vtkAssignCoordinatesLayoutStrategy NewInstance()
		{
			vtkAssignCoordinatesLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignCoordinatesLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060073E0 RID: 29664
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073E1 RID: 29665 RVA: 0x000A78A4 File Offset: 0x000A5AA4
		public new static vtkAssignCoordinatesLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkAssignCoordinatesLayoutStrategy vtkAssignCoordinatesLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssignCoordinatesLayoutStrategy = (vtkAssignCoordinatesLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssignCoordinatesLayoutStrategy.Register(null);
				}
			}
			return vtkAssignCoordinatesLayoutStrategy;
		}

		// Token: 0x060073E2 RID: 29666
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignCoordinatesLayoutStrategy_SetXCoordArrayName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for the x coordinate values.
		/// </summary>
		// Token: 0x060073E3 RID: 29667 RVA: 0x000A7923 File Offset: 0x000A5B23
		public virtual void SetXCoordArrayName(string name)
		{
			vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_SetXCoordArrayName_12(base.GetCppThis(), name);
		}

		// Token: 0x060073E4 RID: 29668
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignCoordinatesLayoutStrategy_SetYCoordArrayName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for the y coordinate values.
		/// </summary>
		// Token: 0x060073E5 RID: 29669 RVA: 0x000A7933 File Offset: 0x000A5B33
		public virtual void SetYCoordArrayName(string name)
		{
			vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_SetYCoordArrayName_13(base.GetCppThis(), name);
		}

		// Token: 0x060073E6 RID: 29670
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignCoordinatesLayoutStrategy_SetZCoordArrayName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for the z coordinate values.
		/// </summary>
		// Token: 0x060073E7 RID: 29671 RVA: 0x000A7943 File Offset: 0x000A5B43
		public virtual void SetZCoordArrayName(string name)
		{
			vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_SetZCoordArrayName_14(base.GetCppThis(), name);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A0A RID: 2570
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssignCoordinatesLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A0B RID: 2571
		public new static readonly string MRClassNameKey = "class vtkAssignCoordinatesLayoutStrategy";
	}
}
