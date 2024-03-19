using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAssignCoordinates
	/// </summary>
	/// <remarks>
	///    Given two(or three) arrays take the values
	/// in those arrays and simply assign them to the coordinates of the vertices.
	///
	///
	/// Given two(or three) arrays take the values in those arrays and simply assign
	/// them to the coordinates of the vertices. Yes you could do this with the array
	/// calculator, but your mom wears army boots so we're not going to.
	/// </remarks>
	// Token: 0x0200027C RID: 636
	public class vtkAssignCoordinates : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007389 RID: 29577 RVA: 0x000A7073 File Offset: 0x000A5273
		static vtkAssignCoordinates()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssignCoordinates.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssignCoordinates"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600738A RID: 29578 RVA: 0x000A709B File Offset: 0x000A529B
		public vtkAssignCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600738B RID: 29579
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600738C RID: 29580 RVA: 0x000A70AC File Offset: 0x000A52AC
		public new static vtkAssignCoordinates New()
		{
			vtkAssignCoordinates result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssignCoordinates.vtkAssignCoordinates_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignCoordinates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600738D RID: 29581 RVA: 0x000A7100 File Offset: 0x000A5300
		public vtkAssignCoordinates() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAssignCoordinates.vtkAssignCoordinates_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600738E RID: 29582 RVA: 0x000A7144 File Offset: 0x000A5344
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600738F RID: 29583
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssignCoordinates_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007390 RID: 29584 RVA: 0x000A7150 File Offset: 0x000A5350
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAssignCoordinates.vtkAssignCoordinates_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06007391 RID: 29585
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssignCoordinates_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007392 RID: 29586 RVA: 0x000A7170 File Offset: 0x000A5370
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAssignCoordinates.vtkAssignCoordinates_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06007393 RID: 29587
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinates_GetXCoordArrayName_03(HandleRef pThis);

		/// <summary>
		/// Set the x coordinate array name.
		/// </summary>
		// Token: 0x06007394 RID: 29588 RVA: 0x000A718C File Offset: 0x000A538C
		public virtual string GetXCoordArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAssignCoordinates.vtkAssignCoordinates_GetXCoordArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007395 RID: 29589
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinates_GetYCoordArrayName_04(HandleRef pThis);

		/// <summary>
		/// Set the y coordinate array name.
		/// </summary>
		// Token: 0x06007396 RID: 29590 RVA: 0x000A71C8 File Offset: 0x000A53C8
		public virtual string GetYCoordArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAssignCoordinates.vtkAssignCoordinates_GetYCoordArrayName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007397 RID: 29591
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinates_GetZCoordArrayName_05(HandleRef pThis);

		/// <summary>
		/// Set the z coordinate array name.
		/// </summary>
		// Token: 0x06007398 RID: 29592 RVA: 0x000A7204 File Offset: 0x000A5404
		public virtual string GetZCoordArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAssignCoordinates.vtkAssignCoordinates_GetZCoordArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007399 RID: 29593
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssignCoordinates_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600739A RID: 29594 RVA: 0x000A7240 File Offset: 0x000A5440
		public override int IsA(string type)
		{
			return vtkAssignCoordinates.vtkAssignCoordinates_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600739B RID: 29595
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssignCoordinates_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600739C RID: 29596 RVA: 0x000A7260 File Offset: 0x000A5460
		public new static int IsTypeOf(string type)
		{
			return vtkAssignCoordinates.vtkAssignCoordinates_IsTypeOf_07(type);
		}

		// Token: 0x0600739D RID: 29597
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinates_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600739E RID: 29598 RVA: 0x000A727C File Offset: 0x000A547C
		public new vtkAssignCoordinates NewInstance()
		{
			vtkAssignCoordinates result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssignCoordinates.vtkAssignCoordinates_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignCoordinates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600739F RID: 29599
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssignCoordinates_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073A0 RID: 29600 RVA: 0x000A72D8 File Offset: 0x000A54D8
		public new static vtkAssignCoordinates SafeDownCast(vtkObjectBase o)
		{
			vtkAssignCoordinates vtkAssignCoordinates = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssignCoordinates.vtkAssignCoordinates_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssignCoordinates = (vtkAssignCoordinates)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssignCoordinates.Register(null);
				}
			}
			return vtkAssignCoordinates;
		}

		// Token: 0x060073A1 RID: 29601
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignCoordinates_SetJitter_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set if you want a random jitter
		/// </summary>
		// Token: 0x060073A2 RID: 29602 RVA: 0x000A7357 File Offset: 0x000A5557
		public virtual void SetJitter(bool _arg)
		{
			vtkAssignCoordinates.vtkAssignCoordinates_SetJitter_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060073A3 RID: 29603
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignCoordinates_SetXCoordArrayName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the x coordinate array name.
		/// </summary>
		// Token: 0x060073A4 RID: 29604 RVA: 0x000A736F File Offset: 0x000A556F
		public virtual void SetXCoordArrayName(string _arg)
		{
			vtkAssignCoordinates.vtkAssignCoordinates_SetXCoordArrayName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060073A5 RID: 29605
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignCoordinates_SetYCoordArrayName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the y coordinate array name.
		/// </summary>
		// Token: 0x060073A6 RID: 29606 RVA: 0x000A737F File Offset: 0x000A557F
		public virtual void SetYCoordArrayName(string _arg)
		{
			vtkAssignCoordinates.vtkAssignCoordinates_SetYCoordArrayName_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060073A7 RID: 29607
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssignCoordinates_SetZCoordArrayName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the z coordinate array name.
		/// </summary>
		// Token: 0x060073A8 RID: 29608 RVA: 0x000A738F File Offset: 0x000A558F
		public virtual void SetZCoordArrayName(string _arg)
		{
			vtkAssignCoordinates.vtkAssignCoordinates_SetZCoordArrayName_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A06 RID: 2566
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssignCoordinates";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A07 RID: 2567
		public new static readonly string MRClassNameKey = "class vtkAssignCoordinates";
	}
}
