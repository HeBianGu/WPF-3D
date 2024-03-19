using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractiveArea
	/// </summary>
	/// <remarks>
	///    Implements zooming and panning in a vtkContextArea.
	///
	/// Implements zooming and panning in a vtkContextArea.
	/// </remarks>
	// Token: 0x02000650 RID: 1616
	public class vtkInteractiveArea : vtkContextArea
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060117E0 RID: 71648 RVA: 0x001867AD File Offset: 0x001849AD
		static vtkInteractiveArea()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractiveArea.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractiveArea"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060117E1 RID: 71649 RVA: 0x001867D5 File Offset: 0x001849D5
		public vtkInteractiveArea(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060117E2 RID: 71650
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractiveArea_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117E3 RID: 71651 RVA: 0x001867E4 File Offset: 0x001849E4
		public new static vtkInteractiveArea New()
		{
			vtkInteractiveArea result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractiveArea.vtkInteractiveArea_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractiveArea)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117E4 RID: 71652 RVA: 0x00186838 File Offset: 0x00184A38
		public vtkInteractiveArea() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractiveArea.vtkInteractiveArea_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060117E5 RID: 71653 RVA: 0x0018687C File Offset: 0x00184A7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060117E6 RID: 71654
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractiveArea_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117E7 RID: 71655 RVA: 0x00186888 File Offset: 0x00184A88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractiveArea.vtkInteractiveArea_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060117E8 RID: 71656
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractiveArea_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117E9 RID: 71657 RVA: 0x001868A8 File Offset: 0x00184AA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractiveArea.vtkInteractiveArea_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060117EA RID: 71658
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractiveArea_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117EB RID: 71659 RVA: 0x001868C4 File Offset: 0x00184AC4
		public override int IsA(string type)
		{
			return vtkInteractiveArea.vtkInteractiveArea_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060117EC RID: 71660
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractiveArea_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117ED RID: 71661 RVA: 0x001868E4 File Offset: 0x00184AE4
		public new static int IsTypeOf(string type)
		{
			return vtkInteractiveArea.vtkInteractiveArea_IsTypeOf_04(type);
		}

		// Token: 0x060117EE RID: 71662
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractiveArea_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117EF RID: 71663 RVA: 0x00186900 File Offset: 0x00184B00
		public new vtkInteractiveArea NewInstance()
		{
			vtkInteractiveArea result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractiveArea.vtkInteractiveArea_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractiveArea)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060117F0 RID: 71664
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInteractiveArea_Paint_07(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// \brief vtkAbstractContextItem API
		/// </summary>
		// Token: 0x060117F1 RID: 71665 RVA: 0x0018695C File Offset: 0x00184B5C
		public override bool Paint(vtkContext2D painter)
		{
			return vtkInteractiveArea.vtkInteractiveArea_Paint_07(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060117F2 RID: 71666
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractiveArea_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117F3 RID: 71667 RVA: 0x00186998 File Offset: 0x00184B98
		public new static vtkInteractiveArea SafeDownCast(vtkObjectBase o)
		{
			vtkInteractiveArea vtkInteractiveArea = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractiveArea.vtkInteractiveArea_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractiveArea = (vtkInteractiveArea)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractiveArea.Register(null);
				}
			}
			return vtkInteractiveArea;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001430 RID: 5168
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractiveArea";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001431 RID: 5169
		public new static readonly string MRClassNameKey = "class vtkInteractiveArea";
	}
}
