using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLevelIdScalars
	/// </summary>
	/// <remarks>
	///    Empty class for backwards compatibility.
	/// </remarks>
	// Token: 0x020008AA RID: 2218
	public class vtkLevelIdScalars : vtkOverlappingAMRLevelIdScalars
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016FC2 RID: 94146 RVA: 0x00204D2F File Offset: 0x00202F2F
		static vtkLevelIdScalars()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLevelIdScalars.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLevelIdScalars"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016FC3 RID: 94147 RVA: 0x00204D57 File Offset: 0x00202F57
		public vtkLevelIdScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016FC4 RID: 94148
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLevelIdScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FC5 RID: 94149 RVA: 0x00204D68 File Offset: 0x00202F68
		public new static vtkLevelIdScalars New()
		{
			vtkLevelIdScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLevelIdScalars.vtkLevelIdScalars_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLevelIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FC6 RID: 94150 RVA: 0x00204DBC File Offset: 0x00202FBC
		public vtkLevelIdScalars() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLevelIdScalars.vtkLevelIdScalars_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016FC7 RID: 94151 RVA: 0x00204E00 File Offset: 0x00203000
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016FC8 RID: 94152
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLevelIdScalars_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FC9 RID: 94153 RVA: 0x00204E0C File Offset: 0x0020300C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLevelIdScalars.vtkLevelIdScalars_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016FCA RID: 94154
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLevelIdScalars_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FCB RID: 94155 RVA: 0x00204E2C File Offset: 0x0020302C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLevelIdScalars.vtkLevelIdScalars_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016FCC RID: 94156
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLevelIdScalars_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FCD RID: 94157 RVA: 0x00204E48 File Offset: 0x00203048
		public override int IsA(string type)
		{
			return vtkLevelIdScalars.vtkLevelIdScalars_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016FCE RID: 94158
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLevelIdScalars_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FCF RID: 94159 RVA: 0x00204E68 File Offset: 0x00203068
		public new static int IsTypeOf(string type)
		{
			return vtkLevelIdScalars.vtkLevelIdScalars_IsTypeOf_04(type);
		}

		// Token: 0x06016FD0 RID: 94160
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLevelIdScalars_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FD1 RID: 94161 RVA: 0x00204E84 File Offset: 0x00203084
		public new vtkLevelIdScalars NewInstance()
		{
			vtkLevelIdScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLevelIdScalars.vtkLevelIdScalars_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLevelIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016FD2 RID: 94162
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLevelIdScalars_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FD3 RID: 94163 RVA: 0x00204EE0 File Offset: 0x002030E0
		public new static vtkLevelIdScalars SafeDownCast(vtkObjectBase o)
		{
			vtkLevelIdScalars vtkLevelIdScalars = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLevelIdScalars.vtkLevelIdScalars_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLevelIdScalars = (vtkLevelIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLevelIdScalars.Register(null);
				}
			}
			return vtkLevelIdScalars;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019BA RID: 6586
		public new const string MRFullTypeName = "Kitware.VTK.vtkLevelIdScalars";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019BB RID: 6587
		public new static readonly string MRClassNameKey = "class vtkLevelIdScalars";
	}
}
