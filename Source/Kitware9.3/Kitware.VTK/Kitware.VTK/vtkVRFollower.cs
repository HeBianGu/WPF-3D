using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRFollower
	/// </summary>
	/// <remarks>
	///    VR Follower
	///
	/// vtkVRFollower a follower that aligns with PhysicalViewUp
	/// </remarks>
	// Token: 0x020000BB RID: 187
	public class vtkVRFollower : vtkFollower
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002940 RID: 10560 RVA: 0x0003CBCF File Offset: 0x0003ADCF
		static vtkVRFollower()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRFollower.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRFollower"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002941 RID: 10561 RVA: 0x0003CBF7 File Offset: 0x0003ADF7
		public vtkVRFollower(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002942 RID: 10562
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRFollower_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002943 RID: 10563 RVA: 0x0003CC08 File Offset: 0x0003AE08
		public new static vtkVRFollower New()
		{
			vtkVRFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRFollower.vtkVRFollower_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002944 RID: 10564 RVA: 0x0003CC5C File Offset: 0x0003AE5C
		public vtkVRFollower() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVRFollower.vtkVRFollower_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002945 RID: 10565 RVA: 0x0003CCA0 File Offset: 0x0003AEA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002946 RID: 10566
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRFollower_ComputeMatrix_01(HandleRef pThis);

		/// <summary>
		/// Generate the matrix based on ivars. This method overloads its superclasses
		/// ComputeMatrix() method due to the special vtkFollower matrix operations.
		/// </summary>
		// Token: 0x06002947 RID: 10567 RVA: 0x0003CCAB File Offset: 0x0003AEAB
		public override void ComputeMatrix()
		{
			vtkVRFollower.vtkVRFollower_ComputeMatrix_01(base.GetCppThis());
		}

		// Token: 0x06002948 RID: 10568
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRFollower_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002949 RID: 10569 RVA: 0x0003CCBC File Offset: 0x0003AEBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRFollower.vtkVRFollower_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600294A RID: 10570
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRFollower_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600294B RID: 10571 RVA: 0x0003CCDC File Offset: 0x0003AEDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRFollower.vtkVRFollower_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600294C RID: 10572
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRFollower_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600294D RID: 10573 RVA: 0x0003CCF8 File Offset: 0x0003AEF8
		public override int IsA(string type)
		{
			return vtkVRFollower.vtkVRFollower_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600294E RID: 10574
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRFollower_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600294F RID: 10575 RVA: 0x0003CD18 File Offset: 0x0003AF18
		public new static int IsTypeOf(string type)
		{
			return vtkVRFollower.vtkVRFollower_IsTypeOf_05(type);
		}

		// Token: 0x06002950 RID: 10576
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRFollower_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002951 RID: 10577 RVA: 0x0003CD34 File Offset: 0x0003AF34
		public new vtkVRFollower NewInstance()
		{
			vtkVRFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRFollower.vtkVRFollower_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002952 RID: 10578
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRFollower_Render_08(HandleRef pThis, HandleRef ren);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002953 RID: 10579 RVA: 0x0003CD90 File Offset: 0x0003AF90
		public override void Render(vtkRenderer ren)
		{
			vtkVRFollower.vtkVRFollower_Render_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06002954 RID: 10580
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRFollower_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002955 RID: 10581 RVA: 0x0003CDC0 File Offset: 0x0003AFC0
		public new static vtkVRFollower SafeDownCast(vtkObjectBase o)
		{
			vtkVRFollower vtkVRFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRFollower.vtkVRFollower_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRFollower = (vtkVRFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRFollower.Register(null);
				}
			}
			return vtkVRFollower;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000562 RID: 1378
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRFollower";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000563 RID: 1379
		public new static readonly string MRClassNameKey = "class vtkVRFollower";
	}
}
