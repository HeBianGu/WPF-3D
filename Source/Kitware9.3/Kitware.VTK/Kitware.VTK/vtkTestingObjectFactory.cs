using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200005B RID: 91
	public class vtkTestingObjectFactory : vtkObjectFactory
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600104C RID: 4172 RVA: 0x0001D791 File Offset: 0x0001B991
		static vtkTestingObjectFactory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTestingObjectFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTestingObjectFactory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600104D RID: 4173 RVA: 0x0001D7B9 File Offset: 0x0001B9B9
		public vtkTestingObjectFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600104E RID: 4174
		[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTestingObjectFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600104F RID: 4175 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		public new static vtkTestingObjectFactory New()
		{
			vtkTestingObjectFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTestingObjectFactory.vtkTestingObjectFactory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTestingObjectFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001050 RID: 4176 RVA: 0x0001D81C File Offset: 0x0001BA1C
		public vtkTestingObjectFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTestingObjectFactory.vtkTestingObjectFactory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001051 RID: 4177 RVA: 0x0001D860 File Offset: 0x0001BA60
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001052 RID: 4178
		[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTestingObjectFactory_GetDescription_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001053 RID: 4179 RVA: 0x0001D86C File Offset: 0x0001BA6C
		public override string GetDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkTestingObjectFactory.vtkTestingObjectFactory_GetDescription_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001054 RID: 4180
		[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTestingObjectFactory_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001055 RID: 4181 RVA: 0x0001D8A8 File Offset: 0x0001BAA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTestingObjectFactory.vtkTestingObjectFactory_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06001056 RID: 4182
		[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTestingObjectFactory_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001057 RID: 4183 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTestingObjectFactory.vtkTestingObjectFactory_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06001058 RID: 4184
		[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTestingObjectFactory_GetVTKSourceVersion_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001059 RID: 4185 RVA: 0x0001D8E4 File Offset: 0x0001BAE4
		public override string GetVTKSourceVersion()
		{
			string s = Marshal.PtrToStringAnsi(vtkTestingObjectFactory.vtkTestingObjectFactory_GetVTKSourceVersion_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600105A RID: 4186
		[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTestingObjectFactory_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600105B RID: 4187 RVA: 0x0001D920 File Offset: 0x0001BB20
		public override int IsA(string type)
		{
			return vtkTestingObjectFactory.vtkTestingObjectFactory_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600105C RID: 4188
		[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTestingObjectFactory_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600105D RID: 4189 RVA: 0x0001D940 File Offset: 0x0001BB40
		public new static int IsTypeOf(string type)
		{
			return vtkTestingObjectFactory.vtkTestingObjectFactory_IsTypeOf_06(type);
		}

		// Token: 0x0600105E RID: 4190
		[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTestingObjectFactory_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600105F RID: 4191 RVA: 0x0001D95C File Offset: 0x0001BB5C
		public new vtkTestingObjectFactory NewInstance()
		{
			vtkTestingObjectFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTestingObjectFactory.vtkTestingObjectFactory_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTestingObjectFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001060 RID: 4192
		[DllImport("Kitware.VTK.TestingRendering.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTestingObjectFactory_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001061 RID: 4193 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
		public new static vtkTestingObjectFactory SafeDownCast(vtkObjectBase o)
		{
			vtkTestingObjectFactory vtkTestingObjectFactory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTestingObjectFactory.vtkTestingObjectFactory_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTestingObjectFactory = (vtkTestingObjectFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTestingObjectFactory.Register(null);
				}
			}
			return vtkTestingObjectFactory;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000436 RID: 1078
		public new const string MRFullTypeName = "Kitware.VTK.vtkTestingObjectFactory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000437 RID: 1079
		public new static readonly string MRClassNameKey = "class vtkTestingObjectFactory";
	}
}
