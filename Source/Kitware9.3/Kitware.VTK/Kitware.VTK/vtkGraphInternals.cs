using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphInternals
	/// </summary>
	/// <remarks>
	///    Internal representation of vtkGraph
	///
	///
	/// This is the internal representation of vtkGraph, used only in rare cases
	/// where one must modify that representation.
	/// </remarks>
	// Token: 0x02000A55 RID: 2645
	public class vtkGraphInternals : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B9EC RID: 113132 RVA: 0x0026A843 File Offset: 0x00268A43
		static vtkGraphInternals()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphInternals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphInternals"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B9ED RID: 113133 RVA: 0x0026A86B File Offset: 0x00268A6B
		public vtkGraphInternals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B9EE RID: 113134
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphInternals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9EF RID: 113135 RVA: 0x0026A87C File Offset: 0x00268A7C
		public new static vtkGraphInternals New()
		{
			vtkGraphInternals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphInternals.vtkGraphInternals_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphInternals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9F0 RID: 113136 RVA: 0x0026A8D0 File Offset: 0x00268AD0
		public vtkGraphInternals() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphInternals.vtkGraphInternals_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B9F1 RID: 113137 RVA: 0x0026A914 File Offset: 0x00268B14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B9F2 RID: 113138
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphInternals_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9F3 RID: 113139 RVA: 0x0026A920 File Offset: 0x00268B20
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphInternals.vtkGraphInternals_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601B9F4 RID: 113140
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphInternals_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9F5 RID: 113141 RVA: 0x0026A940 File Offset: 0x00268B40
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphInternals.vtkGraphInternals_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601B9F6 RID: 113142
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphInternals_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9F7 RID: 113143 RVA: 0x0026A95C File Offset: 0x00268B5C
		public override int IsA(string type)
		{
			return vtkGraphInternals.vtkGraphInternals_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601B9F8 RID: 113144
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphInternals_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9F9 RID: 113145 RVA: 0x0026A97C File Offset: 0x00268B7C
		public new static int IsTypeOf(string type)
		{
			return vtkGraphInternals.vtkGraphInternals_IsTypeOf_04(type);
		}

		// Token: 0x0601B9FA RID: 113146
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphInternals_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9FB RID: 113147 RVA: 0x0026A998 File Offset: 0x00268B98
		public new vtkGraphInternals NewInstance()
		{
			vtkGraphInternals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphInternals.vtkGraphInternals_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphInternals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B9FC RID: 113148
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphInternals_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B9FD RID: 113149 RVA: 0x0026A9F4 File Offset: 0x00268BF4
		public new static vtkGraphInternals SafeDownCast(vtkObjectBase o)
		{
			vtkGraphInternals vtkGraphInternals = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphInternals.vtkGraphInternals_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphInternals = (vtkGraphInternals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphInternals.Register(null);
				}
			}
			return vtkGraphInternals;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D9E RID: 7582
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphInternals";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D9F RID: 7583
		public new static readonly string MRClassNameKey = "class vtkGraphInternals";
	}
}
