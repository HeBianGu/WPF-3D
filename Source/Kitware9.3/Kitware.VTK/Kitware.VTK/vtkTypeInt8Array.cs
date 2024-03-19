using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B2A RID: 2858
	public class vtkTypeInt8Array : vtkSignedCharArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DFE2 RID: 122850 RVA: 0x002A5A67 File Offset: 0x002A3C67
		static vtkTypeInt8Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeInt8Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeInt8Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DFE3 RID: 122851 RVA: 0x002A5A8F File Offset: 0x002A3C8F
		public vtkTypeInt8Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DFE4 RID: 122852
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt8Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601DFE5 RID: 122853 RVA: 0x002A5AA0 File Offset: 0x002A3CA0
		public new static vtkTypeInt8Array New()
		{
			vtkTypeInt8Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt8Array.vtkTypeInt8Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt8Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DFE6 RID: 122854 RVA: 0x002A5AF4 File Offset: 0x002A3CF4
		public vtkTypeInt8Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeInt8Array.vtkTypeInt8Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DFE7 RID: 122855 RVA: 0x002A5B38 File Offset: 0x002A3D38
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DFE8 RID: 122856
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt8Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601DFE9 RID: 122857 RVA: 0x002A5B44 File Offset: 0x002A3D44
		public new static vtkTypeInt8Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeInt8Array vtkTypeInt8Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt8Array.vtkTypeInt8Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt8Array = (vtkTypeInt8Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt8Array.Register(null);
				}
			}
			return vtkTypeInt8Array;
		}

		// Token: 0x0601DFEA RID: 122858
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeInt8Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601DFEB RID: 122859 RVA: 0x002A5BC4 File Offset: 0x002A3DC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeInt8Array.vtkTypeInt8Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601DFEC RID: 122860
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeInt8Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601DFED RID: 122861 RVA: 0x002A5BE4 File Offset: 0x002A3DE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeInt8Array.vtkTypeInt8Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601DFEE RID: 122862
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeInt8Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601DFEF RID: 122863 RVA: 0x002A5C00 File Offset: 0x002A3E00
		public override int IsA(string type)
		{
			return vtkTypeInt8Array.vtkTypeInt8Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601DFF0 RID: 122864
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeInt8Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601DFF1 RID: 122865 RVA: 0x002A5C20 File Offset: 0x002A3E20
		public new static int IsTypeOf(string type)
		{
			return vtkTypeInt8Array.vtkTypeInt8Array_IsTypeOf_05(type);
		}

		// Token: 0x0601DFF2 RID: 122866
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt8Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601DFF3 RID: 122867 RVA: 0x002A5C3C File Offset: 0x002A3E3C
		public new vtkTypeInt8Array NewInstance()
		{
			vtkTypeInt8Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt8Array.vtkTypeInt8Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt8Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DFF4 RID: 122868
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt8Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601DFF5 RID: 122869 RVA: 0x002A5C98 File Offset: 0x002A3E98
		public new static vtkTypeInt8Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeInt8Array vtkTypeInt8Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt8Array.vtkTypeInt8Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt8Array = (vtkTypeInt8Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt8Array.Register(null);
				}
			}
			return vtkTypeInt8Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA3 RID: 8099
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeInt8Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA4 RID: 8100
		public new static readonly string MRClassNameKey = "class vtkTypeInt8Array";
	}
}
