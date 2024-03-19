using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleTrackball
	/// </summary>
	/// <remarks>
	///    provides trackball motion control
	///
	///
	/// vtkInteractorStyleTrackball is an implementation of vtkInteractorStyle
	/// that defines the trackball style. It is now deprecated and as such a
	/// subclass of vtkInteractorStyleSwitch
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleSwitch vtkInteractorStyleTrackballActor vtkInteractorStyleJoystickCamera
	/// </seealso>
	// Token: 0x02000405 RID: 1029
	public class vtkInteractorStyleTrackball : vtkInteractorStyleSwitch
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C3C5 RID: 50117 RVA: 0x001105E7 File Offset: 0x0010E7E7
		static vtkInteractorStyleTrackball()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTrackball.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTrackball"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C3C6 RID: 50118 RVA: 0x0011060F File Offset: 0x0010E80F
		public vtkInteractorStyleTrackball(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C3C7 RID: 50119
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTrackball_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3C8 RID: 50120 RVA: 0x00110620 File Offset: 0x0010E820
		public new static vtkInteractorStyleTrackball New()
		{
			vtkInteractorStyleTrackball result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackball)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3C9 RID: 50121 RVA: 0x00110674 File Offset: 0x0010E874
		public vtkInteractorStyleTrackball() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C3CA RID: 50122 RVA: 0x001106B8 File Offset: 0x0010E8B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C3CB RID: 50123
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTrackball_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3CC RID: 50124 RVA: 0x001106C4 File Offset: 0x0010E8C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C3CD RID: 50125
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTrackball_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3CE RID: 50126 RVA: 0x001106E4 File Offset: 0x0010E8E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C3CF RID: 50127
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTrackball_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3D0 RID: 50128 RVA: 0x00110700 File Offset: 0x0010E900
		public override int IsA(string type)
		{
			return vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C3D1 RID: 50129
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTrackball_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3D2 RID: 50130 RVA: 0x00110720 File Offset: 0x0010E920
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_IsTypeOf_04(type);
		}

		// Token: 0x0600C3D3 RID: 50131
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTrackball_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3D4 RID: 50132 RVA: 0x0011073C File Offset: 0x0010E93C
		public new vtkInteractorStyleTrackball NewInstance()
		{
			vtkInteractorStyleTrackball result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTrackball)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C3D5 RID: 50133
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTrackball_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C3D6 RID: 50134 RVA: 0x00110798 File Offset: 0x0010E998
		public new static vtkInteractorStyleTrackball SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTrackball vtkInteractorStyleTrackball = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTrackball.vtkInteractorStyleTrackball_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTrackball = (vtkInteractorStyleTrackball)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTrackball.Register(null);
				}
			}
			return vtkInteractorStyleTrackball;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E7C RID: 3708
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTrackball";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E7D RID: 3709
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleTrackball";
	}
}
