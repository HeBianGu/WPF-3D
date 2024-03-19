using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHandleSource
	/// </summary>
	/// <remarks>
	///    interface that can be inherited to define handler sources for any kind of interaction.
	///
	/// vtkHandleSource is a pure abstract class defining an interface for handler sources.
	/// Any child of this class is supposed to define an access to its position, size and direction, if
	/// any. On this purpose, the internal getters/setters are left to be redefined by the subclasses.
	/// It is derived by vtkPointHandleSource for example.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointHandleSource, vtkCameraHandleSource
	/// </seealso>
	// Token: 0x020002E2 RID: 738
	public abstract class vtkHandleSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060084C0 RID: 33984 RVA: 0x000BD8BB File Offset: 0x000BBABB
		static vtkHandleSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHandleSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHandleSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060084C1 RID: 33985 RVA: 0x000BD8E3 File Offset: 0x000BBAE3
		public vtkHandleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060084C2 RID: 33986 RVA: 0x000BD8F1 File Offset: 0x000BBAF1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060084C3 RID: 33987
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_DirectionalOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get if the handle should take account on this-&gt;Direction.
		/// The meaning of this direction varies on
		/// the subclasses implementation.
		/// The default value is false.
		/// </summary>
		// Token: 0x060084C4 RID: 33988 RVA: 0x000BD8FC File Offset: 0x000BBAFC
		public virtual void DirectionalOff()
		{
			vtkHandleSource.vtkHandleSource_DirectionalOff_01(base.GetCppThis());
		}

		// Token: 0x060084C5 RID: 33989
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_DirectionalOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get if the handle should take account on this-&gt;Direction.
		/// The meaning of this direction varies on
		/// the subclasses implementation.
		/// The default value is false.
		/// </summary>
		// Token: 0x060084C6 RID: 33990 RVA: 0x000BD90B File Offset: 0x000BBB0B
		public virtual void DirectionalOn()
		{
			vtkHandleSource.vtkHandleSource_DirectionalOn_02(base.GetCppThis());
		}

		// Token: 0x060084C7 RID: 33991
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_GetDirection_03(HandleRef pThis, IntPtr dir);

		/// <summary>
		/// Get the direction of the handle.
		/// The direction meaning depends on subclasses implementations.
		/// </summary>
		// Token: 0x060084C8 RID: 33992 RVA: 0x000BD91A File Offset: 0x000BBB1A
		public void GetDirection(IntPtr dir)
		{
			vtkHandleSource.vtkHandleSource_GetDirection_03(base.GetCppThis(), dir);
		}

		// Token: 0x060084C9 RID: 33993
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleSource_GetDirection_04(HandleRef pThis);

		/// <summary>
		/// Get the direction of the handle.
		/// The direction meaning depends on subclasses implementations.
		/// </summary>
		// Token: 0x060084CA RID: 33994 RVA: 0x000BD92C File Offset: 0x000BBB2C
		public virtual IntPtr GetDirection()
		{
			return vtkHandleSource.vtkHandleSource_GetDirection_04(base.GetCppThis());
		}

		// Token: 0x060084CB RID: 33995
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHandleSource_GetDirectional_05(HandleRef pThis);

		/// <summary>
		/// Set/Get if the handle should take account on this-&gt;Direction.
		/// The meaning of this direction varies on
		/// the subclasses implementation.
		/// The default value is false.
		/// </summary>
		// Token: 0x060084CC RID: 33996 RVA: 0x000BD94C File Offset: 0x000BBB4C
		public virtual bool GetDirectional()
		{
			return vtkHandleSource.vtkHandleSource_GetDirectional_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060084CD RID: 33997
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHandleSource_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084CE RID: 33998 RVA: 0x000BD974 File Offset: 0x000BBB74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHandleSource.vtkHandleSource_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060084CF RID: 33999
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHandleSource_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084D0 RID: 34000 RVA: 0x000BD994 File Offset: 0x000BBB94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHandleSource.vtkHandleSource_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060084D1 RID: 34001
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_GetPosition_08(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Get the position of the handle.
		/// </summary>
		// Token: 0x060084D2 RID: 34002 RVA: 0x000BD9AE File Offset: 0x000BBBAE
		public void GetPosition(IntPtr pos)
		{
			vtkHandleSource.vtkHandleSource_GetPosition_08(base.GetCppThis(), pos);
		}

		// Token: 0x060084D3 RID: 34003
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleSource_GetPosition_09(HandleRef pThis);

		/// <summary>
		/// Get the position of the handle.
		/// </summary>
		// Token: 0x060084D4 RID: 34004 RVA: 0x000BD9C0 File Offset: 0x000BBBC0
		public virtual IntPtr GetPosition()
		{
			return vtkHandleSource.vtkHandleSource_GetPosition_09(base.GetCppThis());
		}

		// Token: 0x060084D5 RID: 34005
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHandleSource_GetSize_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the handle.
		/// The size use depends on subclasses implementations.
		/// The default value is 0.5.
		/// </summary>
		// Token: 0x060084D6 RID: 34006 RVA: 0x000BD9E0 File Offset: 0x000BBBE0
		public virtual double GetSize()
		{
			return vtkHandleSource.vtkHandleSource_GetSize_10(base.GetCppThis());
		}

		// Token: 0x060084D7 RID: 34007
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleSource_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084D8 RID: 34008 RVA: 0x000BDA00 File Offset: 0x000BBC00
		public override int IsA(string type)
		{
			return vtkHandleSource.vtkHandleSource_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x060084D9 RID: 34009
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHandleSource_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084DA RID: 34010 RVA: 0x000BDA20 File Offset: 0x000BBC20
		public new static int IsTypeOf(string type)
		{
			return vtkHandleSource.vtkHandleSource_IsTypeOf_12(type);
		}

		// Token: 0x060084DB RID: 34011
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084DC RID: 34012 RVA: 0x000BDA3C File Offset: 0x000BBC3C
		public new vtkHandleSource NewInstance()
		{
			vtkHandleSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHandleSource.vtkHandleSource_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHandleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060084DD RID: 34013
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHandleSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060084DE RID: 34014 RVA: 0x000BDA98 File Offset: 0x000BBC98
		public new static vtkHandleSource SafeDownCast(vtkObjectBase o)
		{
			vtkHandleSource vtkHandleSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHandleSource.vtkHandleSource_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleSource = (vtkHandleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleSource.Register(null);
				}
			}
			return vtkHandleSource;
		}

		// Token: 0x060084DF RID: 34015
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_SetDirection_15(HandleRef pThis, IntPtr dir);

		/// <summary>
		/// Set the direction of the handle.
		/// The direction meaning depends on subclasses implementations.
		/// </summary>
		// Token: 0x060084E0 RID: 34016 RVA: 0x000BDB17 File Offset: 0x000BBD17
		public void SetDirection(IntPtr dir)
		{
			vtkHandleSource.vtkHandleSource_SetDirection_15(base.GetCppThis(), dir);
		}

		// Token: 0x060084E1 RID: 34017
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_SetDirection_16(HandleRef pThis, double xDir, double yDir, double zDir);

		/// <summary>
		/// Set the direction of the handle.
		/// The direction meaning depends on subclasses implementations.
		/// </summary>
		// Token: 0x060084E2 RID: 34018 RVA: 0x000BDB27 File Offset: 0x000BBD27
		public virtual void SetDirection(double xDir, double yDir, double zDir)
		{
			vtkHandleSource.vtkHandleSource_SetDirection_16(base.GetCppThis(), xDir, yDir, zDir);
		}

		// Token: 0x060084E3 RID: 34019
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_SetDirectional_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the handle should take account on this-&gt;Direction.
		/// The meaning of this direction varies on
		/// the subclasses implementation.
		/// The default value is false.
		/// </summary>
		// Token: 0x060084E4 RID: 34020 RVA: 0x000BDB39 File Offset: 0x000BBD39
		public virtual void SetDirectional(bool _arg)
		{
			vtkHandleSource.vtkHandleSource_SetDirectional_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060084E5 RID: 34021
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_SetPosition_18(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set the position of the handle.
		/// </summary>
		// Token: 0x060084E6 RID: 34022 RVA: 0x000BDB51 File Offset: 0x000BBD51
		public void SetPosition(IntPtr pos)
		{
			vtkHandleSource.vtkHandleSource_SetPosition_18(base.GetCppThis(), pos);
		}

		// Token: 0x060084E7 RID: 34023
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_SetPosition_19(HandleRef pThis, double xPos, double yPos, double zPos);

		/// <summary>
		/// Set the position of the handle.
		/// </summary>
		// Token: 0x060084E8 RID: 34024 RVA: 0x000BDB61 File Offset: 0x000BBD61
		public virtual void SetPosition(double xPos, double yPos, double zPos)
		{
			vtkHandleSource.vtkHandleSource_SetPosition_19(base.GetCppThis(), xPos, yPos, zPos);
		}

		// Token: 0x060084E9 RID: 34025
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHandleSource_SetSize_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of the handle.
		/// The size use depends on subclasses implementations.
		/// The default value is 0.5.
		/// </summary>
		// Token: 0x060084EA RID: 34026 RVA: 0x000BDB73 File Offset: 0x000BBD73
		public virtual void SetSize(double _arg)
		{
			vtkHandleSource.vtkHandleSource_SetSize_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B40 RID: 2880
		public new const string MRFullTypeName = "Kitware.VTK.vtkHandleSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B41 RID: 2881
		public new static readonly string MRClassNameKey = "class vtkHandleSource";
	}
}
