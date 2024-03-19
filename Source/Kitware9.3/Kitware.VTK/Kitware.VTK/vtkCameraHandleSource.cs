using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraHandleSource
	/// </summary>
	/// <remarks>
	///    handle source used to represent one camera.
	///
	/// vtkCameraHandleSource is deriving vtkHandleSource interface.
	/// This handle represents a camera pointing in the focal point direction.
	/// Its position and size can be modified.
	/// If the directional parameter is set to true,
	/// the camera is represented by one big arrow in the focal point direction
	/// and one smaller pointing in the view up direction.
	/// Else, the camera is only displayed as a simple sphere.
	/// </remarks>
	// Token: 0x020002E3 RID: 739
	public class vtkCameraHandleSource : vtkHandleSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060084EB RID: 34027 RVA: 0x000BDB83 File Offset: 0x000BBD83
		static vtkCameraHandleSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraHandleSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraHandleSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060084EC RID: 34028 RVA: 0x000BDBAB File Offset: 0x000BBDAB
		public vtkCameraHandleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060084ED RID: 34029
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraHandleSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084EE RID: 34030 RVA: 0x000BDBBC File Offset: 0x000BBDBC
		public new static vtkCameraHandleSource New()
		{
			vtkCameraHandleSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraHandleSource.vtkCameraHandleSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraHandleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084EF RID: 34031 RVA: 0x000BDC10 File Offset: 0x000BBE10
		public vtkCameraHandleSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraHandleSource.vtkCameraHandleSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060084F0 RID: 34032 RVA: 0x000BDC54 File Offset: 0x000BBE54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060084F1 RID: 34033
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraHandleSource_GetDirection_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the direction of the camera handle.
		/// The direction is used in case the camera handle is
		/// represented as two arrows (when this-&gt;Directional = true).
		/// </summary>
		// Token: 0x060084F2 RID: 34034 RVA: 0x000BDC60 File Offset: 0x000BBE60
		public override IntPtr GetDirection()
		{
			return vtkCameraHandleSource.vtkCameraHandleSource_GetDirection_01(base.GetCppThis());
		}

		// Token: 0x060084F3 RID: 34035
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraHandleSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084F4 RID: 34036 RVA: 0x000BDC80 File Offset: 0x000BBE80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraHandleSource.vtkCameraHandleSource_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060084F5 RID: 34037
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraHandleSource_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084F6 RID: 34038 RVA: 0x000BDCA0 File Offset: 0x000BBEA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraHandleSource.vtkCameraHandleSource_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060084F7 RID: 34039
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraHandleSource_GetPosition_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the camera handle.
		/// </summary>
		// Token: 0x060084F8 RID: 34040 RVA: 0x000BDCBC File Offset: 0x000BBEBC
		public override IntPtr GetPosition()
		{
			return vtkCameraHandleSource.vtkCameraHandleSource_GetPosition_04(base.GetCppThis());
		}

		// Token: 0x060084F9 RID: 34041
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraHandleSource_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084FA RID: 34042 RVA: 0x000BDCDC File Offset: 0x000BBEDC
		public override int IsA(string type)
		{
			return vtkCameraHandleSource.vtkCameraHandleSource_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060084FB RID: 34043
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraHandleSource_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084FC RID: 34044 RVA: 0x000BDCFC File Offset: 0x000BBEFC
		public new static int IsTypeOf(string type)
		{
			return vtkCameraHandleSource.vtkCameraHandleSource_IsTypeOf_06(type);
		}

		// Token: 0x060084FD RID: 34045
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraHandleSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084FE RID: 34046 RVA: 0x000BDD18 File Offset: 0x000BBF18
		public new vtkCameraHandleSource NewInstance()
		{
			vtkCameraHandleSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraHandleSource.vtkCameraHandleSource_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraHandleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060084FF RID: 34047
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraHandleSource_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008500 RID: 34048 RVA: 0x000BDD74 File Offset: 0x000BBF74
		public new static vtkCameraHandleSource SafeDownCast(vtkObjectBase o)
		{
			vtkCameraHandleSource vtkCameraHandleSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraHandleSource.vtkCameraHandleSource_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraHandleSource = (vtkCameraHandleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraHandleSource.Register(null);
				}
			}
			return vtkCameraHandleSource;
		}

		// Token: 0x06008501 RID: 34049
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraHandleSource_SetCamera_10(HandleRef pThis, HandleRef cam);

		/// <summary>
		/// Set the camera represented by this handle.
		/// The camera can't be set to nullptr.
		/// </summary>
		// Token: 0x06008502 RID: 34050 RVA: 0x000BDDF4 File Offset: 0x000BBFF4
		public void SetCamera(vtkCamera cam)
		{
			vtkCameraHandleSource.vtkCameraHandleSource_SetCamera_10(base.GetCppThis(), (cam == null) ? default(HandleRef) : cam.GetCppThis());
		}

		// Token: 0x06008503 RID: 34051
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraHandleSource_SetDirection_11(HandleRef pThis, double xTarget, double yTarget, double zTarget);

		/// <summary>
		/// Set/Get the direction of the camera handle.
		/// The direction is used in case the camera handle is
		/// represented as two arrows (when this-&gt;Directional = true).
		/// </summary>
		// Token: 0x06008504 RID: 34052 RVA: 0x000BDE23 File Offset: 0x000BC023
		public override void SetDirection(double xTarget, double yTarget, double zTarget)
		{
			vtkCameraHandleSource.vtkCameraHandleSource_SetDirection_11(base.GetCppThis(), xTarget, yTarget, zTarget);
		}

		// Token: 0x06008505 RID: 34053
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraHandleSource_SetPosition_12(HandleRef pThis, double xPos, double yPos, double zPos);

		/// <summary>
		/// Set/Get the position of the camera handle.
		/// </summary>
		// Token: 0x06008506 RID: 34054 RVA: 0x000BDE35 File Offset: 0x000BC035
		public override void SetPosition(double xPos, double yPos, double zPos)
		{
			vtkCameraHandleSource.vtkCameraHandleSource_SetPosition_12(base.GetCppThis(), xPos, yPos, zPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B42 RID: 2882
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraHandleSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B43 RID: 2883
		public new static readonly string MRClassNameKey = "class vtkCameraHandleSource";
	}
}
