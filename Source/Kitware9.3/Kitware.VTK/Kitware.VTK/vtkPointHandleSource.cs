using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointHandleSource
	/// </summary>
	/// <remarks>
	///    handle source used to represent points.
	///
	/// vtkPointHandleSource is deriving vtkHandleSource interface.
	/// This handle represents a point with its shape being a sphere.
	/// Its center and radius can be modified.
	/// If the point is also parametered by any direction, it is then
	/// represented as a cone pointing in this direction.
	/// </remarks>
	// Token: 0x02000837 RID: 2103
	public class vtkPointHandleSource : vtkHandleSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015C36 RID: 89142 RVA: 0x001EB472 File Offset: 0x001E9672
		static vtkPointHandleSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointHandleSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointHandleSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015C37 RID: 89143 RVA: 0x001EB49A File Offset: 0x001E969A
		public vtkPointHandleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015C38 RID: 89144
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C39 RID: 89145 RVA: 0x001EB4A8 File Offset: 0x001E96A8
		public new static vtkPointHandleSource New()
		{
			vtkPointHandleSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointHandleSource.vtkPointHandleSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointHandleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C3A RID: 89146 RVA: 0x001EB4FC File Offset: 0x001E96FC
		public vtkPointHandleSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointHandleSource.vtkPointHandleSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015C3B RID: 89147 RVA: 0x001EB540 File Offset: 0x001E9740
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015C3C RID: 89148
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleSource_GetDirection_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the direction of the handle.
		/// The direction is used in case the handle is
		/// represented as a cone (when this-&gt;Directional = true).
		/// The default direction is (1,0,0).
		/// </summary>
		// Token: 0x06015C3D RID: 89149 RVA: 0x001EB54C File Offset: 0x001E974C
		public override IntPtr GetDirection()
		{
			return vtkPointHandleSource.vtkPointHandleSource_GetDirection_01(base.GetCppThis());
		}

		// Token: 0x06015C3E RID: 89150
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointHandleSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C3F RID: 89151 RVA: 0x001EB56C File Offset: 0x001E976C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointHandleSource.vtkPointHandleSource_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06015C40 RID: 89152
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointHandleSource_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C41 RID: 89153 RVA: 0x001EB58C File Offset: 0x001E978C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointHandleSource.vtkPointHandleSource_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06015C42 RID: 89154
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleSource_GetPosition_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the handle.
		/// The default position is (0,0,0).
		/// </summary>
		// Token: 0x06015C43 RID: 89155 RVA: 0x001EB5A8 File Offset: 0x001E97A8
		public override IntPtr GetPosition()
		{
			return vtkPointHandleSource.vtkPointHandleSource_GetPosition_04(base.GetCppThis());
		}

		// Token: 0x06015C44 RID: 89156
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleSource_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C45 RID: 89157 RVA: 0x001EB5C8 File Offset: 0x001E97C8
		public override int IsA(string type)
		{
			return vtkPointHandleSource.vtkPointHandleSource_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06015C46 RID: 89158
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleSource_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C47 RID: 89159 RVA: 0x001EB5E8 File Offset: 0x001E97E8
		public new static int IsTypeOf(string type)
		{
			return vtkPointHandleSource.vtkPointHandleSource_IsTypeOf_06(type);
		}

		// Token: 0x06015C48 RID: 89160
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C49 RID: 89161 RVA: 0x001EB604 File Offset: 0x001E9804
		public new vtkPointHandleSource NewInstance()
		{
			vtkPointHandleSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointHandleSource.vtkPointHandleSource_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointHandleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015C4A RID: 89162
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleSource_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C4B RID: 89163 RVA: 0x001EB660 File Offset: 0x001E9860
		public new static vtkPointHandleSource SafeDownCast(vtkObjectBase o)
		{
			vtkPointHandleSource vtkPointHandleSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointHandleSource.vtkPointHandleSource_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointHandleSource = (vtkPointHandleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointHandleSource.Register(null);
				}
			}
			return vtkPointHandleSource;
		}

		// Token: 0x06015C4C RID: 89164
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleSource_SetDirection_10(HandleRef pThis, double xDir, double yDir, double zDir);

		/// <summary>
		/// Set/Get the direction of the handle.
		/// The direction is used in case the handle is
		/// represented as a cone (when this-&gt;Directional = true).
		/// The default direction is (1,0,0).
		/// </summary>
		// Token: 0x06015C4D RID: 89165 RVA: 0x001EB6DF File Offset: 0x001E98DF
		public override void SetDirection(double xDir, double yDir, double zDir)
		{
			vtkPointHandleSource.vtkPointHandleSource_SetDirection_10(base.GetCppThis(), xDir, yDir, zDir);
		}

		// Token: 0x06015C4E RID: 89166
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleSource_SetPosition_11(HandleRef pThis, double xPos, double yPos, double zPos);

		/// <summary>
		/// Set/Get the position of the handle.
		/// The default position is (0,0,0).
		/// </summary>
		// Token: 0x06015C4F RID: 89167 RVA: 0x001EB6F1 File Offset: 0x001E98F1
		public override void SetPosition(double xPos, double yPos, double zPos)
		{
			vtkPointHandleSource.vtkPointHandleSource_SetPosition_11(base.GetCppThis(), xPos, yPos, zPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C5 RID: 6341
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointHandleSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C6 RID: 6342
		public new static readonly string MRClassNameKey = "class vtkPointHandleSource";
	}
}
